namespace Iterator.BookIterators;

public class BookAuthorIterator : AbstractIterator
{
    public BookAuthorIterator(IEnumerable<IBook> books) : base(books) { }

    public override IEnumerable<IBook> Iterate()
    {
        var sortedBooks = Books.OrderBy(x => x.GetAuthor());
        
        foreach (var book in sortedBooks)
        {
            yield return book;
        }
    }
}