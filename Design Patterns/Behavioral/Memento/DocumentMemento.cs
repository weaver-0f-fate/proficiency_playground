namespace Memento;

public interface IDocumentMemento
{
    public string GetContent();
}

public class DocumentMemento : IDocumentMemento
{
    private readonly string _content;

    public DocumentMemento(string content)
    {
        _content = content;
    }

    public string GetContent()
    {
        return _content;
    }
}