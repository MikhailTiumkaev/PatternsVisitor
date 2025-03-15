// Конкретный класс животного (ConcreteElement)
using Visitor.Interfaces;

public class RangeMonster: IMonster
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit<IMonster>(this);
    }

    public void Hit()
    {
        Console.WriteLine("Hit from the distance");
    }
}