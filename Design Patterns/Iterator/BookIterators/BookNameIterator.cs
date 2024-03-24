namespace Iterator.BookIterators;

public class BookNameIterator : AbstractIterator
{

    public BookNameIterator(IEnumerable<IBook> books) : base(books) { }

    public override IEnumerable<IBook> Iterate()
    {
        var sortedBooks = Books.OrderBy(x => x.GetName());
        
        foreach (var book in sortedBooks)
        {
            yield return book;
        }
    }
}