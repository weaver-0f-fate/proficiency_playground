namespace Iterator;

public interface IBook
{
    public string GetName();
    public string GetAuthor();
    public int GetYear();
}

public class Book : IBook
{
    private string _author;
    private string _name;
    private int _year;

    public Book(string author, string name, int year)
    {
        _author = author;
        _name = name;
        _year = year;
    }

    public override string ToString()
    {
        return $"{_name} book authoring by {_author} was written in {_year}";
    }

    string IBook.GetName()
    {
        return _name;
    }

    public string GetAuthor()
    {
        return _author;
    }

    int IBook.GetYear()
    {
        return _year;
    }
}