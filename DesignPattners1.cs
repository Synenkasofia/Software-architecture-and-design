using System;

// Інтерфейс прототипу
interface IPrototype
{
    IPrototype Clone();
}

// Конкретний прототип
class ConcretePrototype : IPrototype
{
    public string Name { get; set; }

    public ConcretePrototype(string name)
    {
        Name = name;
    }

    public IPrototype Clone() => new ConcretePrototype(Name);
}

class Program
{
    static void Main()
    {
        // Створюємо оригінал
        var original = new ConcretePrototype("Оригінал");
        Console.WriteLine($"Оригінал: {original.Name}");

        // Копіюємо оригінал
        var clone = original.Clone();
        Console.WriteLine($"Копія: {((ConcretePrototype)clone).Name}");
    }
}
