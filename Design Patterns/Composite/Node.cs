namespace Composite;

public interface INode : IElement
{
    public IElement AddLeaf();
    public INode AddNode();
}

public class Node : Element, INode
{
    private List<Element> _elements;

    public Node()
    {
        _elements = new List<Element>();
    }

    protected override void PersonalIncrement()
    {
        Number++;
        foreach (var element in _elements)
        {
            element.Increment();
        }
    }

    protected override void PersonalDecrement()
    {
        Number--;
        foreach (var element in _elements)
        {
            element.Decrement();
        }
    }

    public IElement AddLeaf()
    {
        var newLeaf = new Leaf();
        _elements.Add(newLeaf);
        return newLeaf;
    }

    public INode AddNode()
    {
        var newNode = new Node();
        _elements.Add(newNode);
        return newNode;
    }
}