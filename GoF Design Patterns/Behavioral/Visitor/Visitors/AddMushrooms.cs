namespace Visitor.Visitors;

public class AddMushrooms : AbstractVisitor
{
    public override void Visit(IDish dish)
    {
        dish.AddReagent(Reagent.Mushrooms);
    }
}