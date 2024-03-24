using Iterator.BookIterators;

namespace Iterator;

public interface IBooksCollection
{
    public void AddBook(string author, string name, int year);
    public IBookIterator GetAuthorIterator();
    public IBookIterator GetNameIterator();
    public IBookIterator GetYearIterator();
}

public class BooksCollection : IBooksCollection
{
    private List<IBook> _books;
    
    public BooksCollection()
    {
        _books = new List<IBook>();
    }

    public void AddBook(string author, string name, int year)
    {
        _books.Add(new Book(author, name, year));
    }

    public IBookIterator GetAuthorIterator()
    {
        return new BookAuthorIterator(_books);
    }

    public IBookIterator GetNameIterator()
    {
        return new BookNameIterator(_books);
    }

    public IBookIterator GetYearIterator()
    {
        return new BookYearIterator(_books);
    }
}