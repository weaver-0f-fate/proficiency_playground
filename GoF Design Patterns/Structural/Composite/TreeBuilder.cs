namespace Composite;

public interface ITreeBuilder
{
    public IElement GetDefaultTree();
}

public class TreeBuilder : ITreeBuilder
{
    public IElement GetDefaultTree()
    {
        INode root = new Node();
        root.AddLeaf();
        root.AddLeaf();
        var firstChildNode = root.AddNode();
        firstChildNode.AddLeaf();
        var secondChildNode = firstChildNode.AddNode();
        secondChildNode.AddLeaf();
        secondChildNode.AddNode();
        return root;
    }
}