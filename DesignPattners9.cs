using System;

// Інтерфейс, який визначає операцію
public interface ISubject
{
    void Request();
}

// Реальний суб'єкт, до якого будемо звертатися через проксі
public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("Запит оброблений реальним суб'єктом.");
    }
}
