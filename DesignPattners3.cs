using System;

// Цільовий інтерфейс
interface ITarget
{
    string Request();
}

// Конкретний клас, який реалізує цільовий інтерфейс
class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public string Request()
    {
        return $"Адаптований: {_adaptee.SpecificRequest()}";
    }
}

// Клас з несумісним інтерфейсом
class Adaptee
{
    public string SpecificRequest() => "Запит від Adaptee";
}

class Program
{
    static void Main()
    {
        Adaptee adaptee = new Adaptee();
        ITarget adapter = new Adapter(adaptee);
        Console.WriteLine(adapter.Request());
    }
}
