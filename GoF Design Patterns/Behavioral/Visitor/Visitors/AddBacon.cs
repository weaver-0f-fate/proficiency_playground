namespace Visitor.Visitors;

public class AddBacon : AbstractVisitor
{
    public override void Visit(IDish dish)
    {
        dish.AddReagent(Reagent.Bacon);
    }
}