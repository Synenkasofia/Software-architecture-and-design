using System;
using System.Collections.Generic;

public interface IObserver
{
    void Update(string message);
}

public class Subject
{
    private readonly List<IObserver> _observers = new List<IObserver>();
    public string State { get; private set; }

    public void Attach(IObserver observer) => _observers.Add(observer);
    public void Detach(IObserver observer) => _observers.Remove(observer);

    public void ChangeState(string newState)
    {
        State = newState;
        Notify();
    }

    private void Notify()
    {
        foreach (var observer in _observers)
            observer.Update(State);
    }
}

public class ConcreteObserver : IObserver
{
    private readonly string _name;

    public ConcreteObserver(string name) => _name = name;

    public void Update(string message) => Console.WriteLine($"Спостерігач {_name} отримав: {message}");
}

class Program
{
    static void Main()
    {
        var subject = new Subject();
        var observerA = new ConcreteObserver("A");
        var observerB = new ConcreteObserver("B");

        subject.Attach(observerA);
        subject.Attach(observerB);

        subject.ChangeState("Стан 1");
        subject.ChangeState("Стан 2");

        subject.Detach(observerA);
        subject.ChangeState("Стан 3");
    }
}
