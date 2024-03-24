namespace Visitor.Visitors;

public class AddSeafood : AbstractVisitor
{
    public override void Visit(IDish dish)
    {
        dish.AddReagent(Reagent.Seafood);
    }
}