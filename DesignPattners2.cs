using System;

class Singleton
{
    private static Singleton _instance;

    // Приватний конструктор, щоб запобігти створенню об'єктів
    private Singleton() { }

    // Глобальна точка доступу до екземпляра
    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("Виконання дії з одинаком.");
    }
}

class Program
{
    static void Main()
    {
        // Отримання єдиного екземпляра
        Singleton singleton = Singleton.Instance;
        singleton.DoSomething();
    }
}
