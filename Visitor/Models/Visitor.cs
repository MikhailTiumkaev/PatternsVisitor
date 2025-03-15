
using Visitor.Interfaces;

// Конкретный класс посетителя (ConcreteVisitor)
public class HitVisitor : IVisitor
{
    public void Visit<T>(IMonster monster)
    {        
        monster.Hit();
    }
}
