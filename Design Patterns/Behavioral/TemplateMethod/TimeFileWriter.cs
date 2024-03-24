namespace TemplateMethod;

public class TimeFileWriter : AbstractFileWriter
{
    protected override string CreateContent()
    {
        return DateTime.Now.ToShortTimeString();
    }
}