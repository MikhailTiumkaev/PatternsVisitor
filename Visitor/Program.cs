using Visitor.Interfaces;

namespace Visitor;
public class Program
{
    static void Main(string[] args)
    {
        // Создаем зоопарк (структуру объектов)
        MonsterZoo zoo = new ();

        // Создаем животных
        IMonster dragon = new FlyingMonster();
        IMonster snake = new MeleeMonster();
        IMonster ant = new RangeMonster();

        // Добавляем животных в зоопарк
        zoo.Attach(dragon);
        zoo.Attach(snake);
        zoo.Attach(ant);

        // Создаем посетителей
        IVisitor hitVisitor = new HitVisitor();

        // Применяем посетителей ко всем животным в зоопарке
        Console.WriteLine("Monster attack:");
        zoo.Accept(hitVisitor);
    }
}

// Класс зоопарк для управления элементами (ObjectStructure)
public class MonsterZoo
{
    private readonly List<IMonster> _monsters = new();

    public void Attach(IMonster monster)
    {
        _monsters.Add(monster);
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var monster in _monsters)
        {
            monster.Accept(visitor);
        }
    }
}