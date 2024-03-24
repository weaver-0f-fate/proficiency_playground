namespace Iterator.BookIterators;

public class BookYearIterator : AbstractIterator
{
    public BookYearIterator(IEnumerable<IBook> books) : base(books) { }

    public override IEnumerable<IBook> Iterate()
    {
        var sortedBooks = Books.OrderBy(x => x.GetYear());
        
        foreach (var book in sortedBooks)
        {
            yield return book;
        }
    }
}