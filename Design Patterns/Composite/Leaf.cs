namespace Composite;

public class Leaf : Element
{
    protected override void PersonalIncrement()
    {
        Number++;
    }

    protected override void PersonalDecrement()
    {
        Number--;
    }
}