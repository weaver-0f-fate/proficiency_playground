namespace TemplateMethod;

public class DateFileWriter : AbstractFileWriter
{
    protected override string CreateContent()
    {
        return DateTime.Now.ToShortDateString();
    }
}