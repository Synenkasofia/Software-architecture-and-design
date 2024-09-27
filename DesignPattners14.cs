using System;

public class Memento
{
    public string State { get; }
    public Memento(string state) => State = state;
}

public class Originator
{
    public string State { get; set; }

    public Memento Save() => new Memento(State);
    public void Restore(Memento memento) => State = memento.State;
}

class Program
{
    static void Main()
    {
        var originator = new Originator { State = "Стан 1" };
        Console.WriteLine("Початковий стан: " + originator.State);

        var memento = originator.Save(); // Зберігаємо знімок

        originator.State = "Стан 2";
        Console.WriteLine("Змінений стан: " + originator.State);

        originator.Restore(memento); // Відновлюємо знімок
        Console.WriteLine("Відновлений стан: " + originator.State);
    }
}
