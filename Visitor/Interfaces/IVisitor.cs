namespace Visitor.Interfaces;

// Интерфейс посетителя (Visitor)
public interface IVisitor
{
    void Visit<T>(IMonster monster);

}