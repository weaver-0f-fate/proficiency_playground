namespace TemplateMethod;

public interface IFileWriter
{
    public void Write(string filePath);
}

public abstract class AbstractFileWriter : IFileWriter
{
    public static IFileWriter GetDateFileWriter() => new DateFileWriter();
    public static IFileWriter GetTimeFileWriter() => new TimeFileWriter();
    
    public void Write(string filePath)
    {
        var content = CreateContent();

        using var writer = new StreamWriter(filePath);

        writer.Write(content);
    }

    protected abstract string CreateContent();
}