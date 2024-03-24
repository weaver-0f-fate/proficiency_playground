namespace Visitor.Visitors;

public class AddCheese : AbstractVisitor
{
    public override void Visit(IDish dish)
    {
        dish.AddReagent(Reagent.Cheese);
    }
}