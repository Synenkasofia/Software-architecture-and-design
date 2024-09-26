using System;

// Компонент
interface IComponent
{
    string Operation();
}

// Конкретний компонент
class ConcreteComponent : IComponent
{
    public string Operation() => "ConcreteComponent";
}

// Декоратори
class DecoratorA : IComponent
{
    IComponent _component;
    public DecoratorA(IComponent component) => _component = component;
    public string Operation() => $"DecoratorA: {_component.Operation()}";
}

class DecoratorB : IComponent
{
    IComponent _component;
    public DecoratorB(IComponent component) => _component = component;
    public string Operation() => $"DecoratorB: {_component.Operation()}";
}

class Program
{
    static void Main()
    {
        IComponent component = new ConcreteComponent();
        Console.WriteLine(component.Operation());

        component = new DecoratorA(component);
        Console.WriteLine(component.Operation());

        component = new DecoratorB(component);
        Console.WriteLine(component.Operation());
    }
}
