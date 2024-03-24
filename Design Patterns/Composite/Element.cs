namespace Composite;

public interface IElement
{
    public void Increment();
    public void Decrement();
}

public abstract class Element : IElement
{
    protected int Number { get; set; }

    protected Element()
    {
        var rnd = new Random();
        Number = rnd.Next(10, 20);
    }
    
    protected abstract void PersonalIncrement();

    protected abstract void PersonalDecrement();
    public void Increment()
    {
        PersonalIncrement();
        AnnounceNumber();
    }

    public void Decrement()
    {
        PersonalDecrement();
        AnnounceNumber();
    }

    private void AnnounceNumber()
    {
        Console.WriteLine($"new number: {Number}");
    }
}