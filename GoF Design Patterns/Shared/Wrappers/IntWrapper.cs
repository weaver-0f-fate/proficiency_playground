namespace Shared.Wrappers;

public class IntWrapper : IComparable<object>
{
    private int Value { get; }

    public IntWrapper(int value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return $"{Value}";
    }

    public int CompareTo(object? obj)
    {
        if (obj is null) return 1;

        var other = obj as IntWrapper;
        if (other != null)
        {
            return Value.CompareTo(other.Value);
        }
        else
        {
            throw new ArgumentException("Object is not an IntWrapper");
        }
    }
}