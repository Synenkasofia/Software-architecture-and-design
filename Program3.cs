//DIP


using System;

interface IMessageService
{
    void SendMessage(string message);
}

class EmailService : IMessageService
{
    public void SendMessage(string message) => Console.WriteLine("Email: " + message);
}

class Notification
{
    private readonly IMessageService _service;

    public Notification(IMessageService service) => _service = service;

    public void Notify(string message) => _service.SendMessage(message);
}

class Program
{
    static void Main()
    {
        var notification = new Notification(new EmailService());
        notification.Notify("Привіт!");
    }
}
