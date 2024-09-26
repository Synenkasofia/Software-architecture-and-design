using System;

class PaymentProcessor
{
    public virtual void ProcessPayment() {}
}

class CreditCardPayment : PaymentProcessor
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Кредитна карта");
    }
}

class PayPalPayment : PaymentProcessor
{
    public override void ProcessPayment()
    {
        Console.WriteLine("PayPal");
    }
}

class Program
{
    static void Main()
    {
        new CreditCardPayment().ProcessPayment();
        new PayPalPayment().ProcessPayment();
    }
}