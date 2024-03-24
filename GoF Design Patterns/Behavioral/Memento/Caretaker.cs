namespace Memento;

public interface ICaretaker
{
    public void SaveMemento(IDocument document);
    public IDocumentMemento RetrieveDocumentVersion(int version);
}

public class Caretaker : ICaretaker
{
    private readonly Dictionary<int, IDocumentMemento> _mementos;
    private int _nextVersion = 1;
    
    public Caretaker()
    {
        _mementos = new Dictionary<int, IDocumentMemento>();
    }

    public void SaveMemento(IDocument document)
    {
        _mementos.Add(_nextVersion, document.CreateMemento());
        _nextVersion++;
    }

    public IDocumentMemento RetrieveDocumentVersion(int version)
    {
        return _mementos[version];
    }
}