// Конкретный класс животного (ConcreteElement)
using Visitor.Interfaces;

public class FlyingMonster : IMonster
{
    public void Hit()
    {
        Console.WriteLine("Hit from the sky");
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit<IMonster>(this);
    }
}