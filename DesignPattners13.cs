using System;

public class Mediator
{
    public void Notify(string component)
    {
        if (component == "A")
            Console.WriteLine("Посередник реагує на компонент A.");
        else if (component == "B")
            Console.WriteLine("Посередник реагує на компонент B.");
    }
}

public class Component
{
    private Mediator _mediator;
    private string _name;

    public Component(Mediator mediator, string name)
    {
        _mediator = mediator;
        _name = name;
    }

    public void DoAction()
    {
        Console.WriteLine($"Компонент {_name} виконує дію.");
        _mediator.Notify(_name);
    }
}

class Program
{
    static void Main()
    {
        Mediator mediator = new Mediator();
        var componentA = new Component(mediator, "A");
        var componentB = new Component(mediator, "B");

        componentA.DoAction();
        componentB.DoAction();
    }
}
