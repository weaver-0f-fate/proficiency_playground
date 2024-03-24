namespace Iterator.BookIterators;

public interface IBookIterator
{
    public IEnumerable<IBook> Iterate();
}

public abstract class AbstractIterator : IBookIterator
{
    protected readonly IEnumerable<IBook> Books;
    
    protected AbstractIterator(IEnumerable<IBook> books)
    {
        Books = books;
    }
    
    public abstract IEnumerable<IBook> Iterate();
}