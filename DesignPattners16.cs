using System;

public interface IState
{
    void Handle(Context context);
}

public class Context
{
    public IState State { get; set; }

    public Context(IState state) => State = state;

    public void Request() => State.Handle(this);
}

public class ConcreteStateA : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Обробка в стані A.");
        context.State = new ConcreteStateB(); // Зміна стану
    }
}

public class ConcreteStateB : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Обробка в стані B.");
        context.State = new ConcreteStateA(); // Зміна стану
    }
}

class Program
{
    static void Main()
    {
        var context = new Context(new ConcreteStateA());

        for (int i = 0; i < 5; i++)
        {
            context.Request(); // Змінюємо стан
        }
    }
}
