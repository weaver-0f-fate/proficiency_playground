namespace Memento;

public interface IDocument
{
    public IDocumentMemento CreateMemento();
    public void SetCotent(string newContent);
    public void RestoreMemento(IDocumentMemento documentMemento);
    public void PrintInfo();
}

public class Document : IDocument
{
    private string _content;
    
    public Document()
    {
        _content = "Initial content";
    }

    public IDocumentMemento CreateMemento()
    {
        return new DocumentMemento(_content);
    }

    public void SetCotent(string newContent)
    {
        _content = newContent;
    }

    public void RestoreMemento(IDocumentMemento documentMemento)
    {
        _content = documentMemento.GetContent();
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Current content: {_content}");
    }
}