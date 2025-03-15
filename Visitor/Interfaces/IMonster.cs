namespace Visitor.Interfaces;

// Интерфейс для элементов, которые будут принимать посетителя (Element)
public interface IMonster
{
    void Hit();
    void Accept(IVisitor visitor);
}