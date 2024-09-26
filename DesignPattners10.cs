using System;

// Абстрактний клас оброблювача
abstract class Handler
{
    protected Handler next;

    public void SetNext(Handler nextHandler) => next = nextHandler;

    public abstract void HandleRequest(int request);
}

// Конкретний оброблювач для малих запитів
class SmallRequestHandler : Handler
{
    public override void HandleRequest(int request)
    {
        if (request < 10)
            Console.WriteLine($"Запит {request} оброблений SmallRequestHandler.");
        else
            next?.HandleRequest(request); // Передаємо запит далі, якщо не можемо обробити
    }
}

// Конкретний оброблювач для всіх інших запитів
class LargeRequestHandler : Handler
{
    public override void HandleRequest(int request)
    {
        Console.WriteLine($"Запит {request} оброблений LargeRequestHandler.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створюємо оброблювачі та налаштовуємо ланцюжок
        Handler handler = new SmallRequestHandler();
        handler.SetNext(new LargeRequestHandler());

        // Відправляємо запити
        int[] requests = { 5, 15, 7, 20 };
        foreach (var request in requests)
        {
            handler.HandleRequest(request);
        }
    }
}
