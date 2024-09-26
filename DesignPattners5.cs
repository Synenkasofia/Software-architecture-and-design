using System;
using System.Collections.Generic;

// Компонент
abstract class Component
{
    public abstract void Operation();
}

// Лист
class Leaf : Component
{
    string _name;
    public Leaf(string name) => _name = name;
    public override void Operation() => Console.WriteLine($"Leaf: {_name}");
}

// Контейнер
class Composite : Component
{
    List<Component> _children = new();
    public void Add(Component component) => _children.Add(component);
    public override void Operation()
    {
        Console.WriteLine("Composite:");
        foreach (var child in _children) child.Operation();
    }
}

class Program
{
    static void Main()
    {
        var root = new Composite();
        root.Add(new Leaf("Leaf 1"));
        root.Add(new Leaf("Leaf 2"));
        
        var subComposite = new Composite();
        subComposite.Add(new Leaf("Leaf 3"));
        root.Add(subComposite);
        
        root.Operation();
    }
}
