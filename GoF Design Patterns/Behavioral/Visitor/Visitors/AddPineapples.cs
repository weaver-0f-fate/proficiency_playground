namespace Visitor.Visitors;

public class AddPineapples : AbstractVisitor
{
    public override void Visit(IDish dish)
    {
        dish.AddReagent(Reagent.Pineapples);
    }
}
