using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml;


namespace Facade;

public interface ICalculator
{
    public Task<int> AddAsync(int intA, int intB);
    public Task<int> DivideAsync(int intA, int intB);
    public Task<int> MultiplyAsync(int intA, int intB);
    public Task<int> SubtractAsync(int intA, int intB);
}

public class Calculator : ICalculator
{
    private readonly HttpClient _httpClient;
    private const string Url = "http://www.dneonline.com/calculator.asmx";
    
    public Calculator(IHttpClientFactory httpFactory)
    {
        _httpClient = httpFactory.CreateClient();
    }
    
    public async Task<int> SubtractAsync(int intA, int intB) => await ExecuteOperation("Subtract", intA, intB);

    public async Task<int> DivideAsync(int intA, int intB) => await ExecuteOperation("Divide", intA, intB);

    public async Task<int> MultiplyAsync(int intA, int intB) => await ExecuteOperation("Multiply", intA, intB);

    public async Task<int> AddAsync(int intA, int intB) => await ExecuteOperation("Add", intA, intB);

    private async Task<int> ExecuteOperation(string operation, int intA, int intB)
    {
        var soapEnvelope = GetSoapEnvelope(operation, intA, intB);
        var content = BuildStringContent(soapEnvelope);

        var response = await _httpClient.PostAsync(Url, content);
        var soapResponse = await response.Content.ReadAsStringAsync();
        
        return GetContentFromResult(soapResponse, operation);
    }

    private string GetSoapEnvelope(string operation, int intA, int intB) 
    {
        return $@"
            <Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"">
                <Body>
                    <{operation} xmlns=""http://tempuri.org/"">
                        <intA>{intA}</intA>
                        <intB>{intB}</intB>
                    </{operation}>
                </Body>
            </Envelope>";
    }

    private StringContent BuildStringContent(string soapEnvelope)
    {
        var content = new StringContent(soapEnvelope, Encoding.UTF8, "application/soap+xml");
        content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/xml")
        {
            CharSet = Encoding.UTF8.WebName
        };
        return content;
    }

    private int GetContentFromResult(string soapResponse, string operation)
    {
        var xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(soapResponse);
        
        var namespaceManager = new XmlNamespaceManager(xmlDoc.NameTable);
        namespaceManager.AddNamespace("ns", "http://tempuri.org/");
        
        var resultNode = xmlDoc.SelectSingleNode($"//ns:{operation}Response/ns:{operation}Result", namespaceManager);
        var result = resultNode?.FirstChild?.Value;

        if (int.TryParse(result, out var intResult))
        {
            return intResult;
        }

        throw new ValidationException("Result is not a number");
    }
}