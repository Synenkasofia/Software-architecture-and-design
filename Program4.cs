//LSP


using System;

class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Птах летить");
    }
}

class Sparrow : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Горобець летить");
    }
}

class Ostrich : Bird
{
    // Страус не літає, тому не перевизначає метод Fly
}

class Program
{
    static void Main()
    {
        Bird bird1 = new Sparrow();
        bird1.Fly(); // Горобець летить

        Bird bird2 = new Ostrich();
        bird2.Fly(); // Страус не може літати, але метод доступний
    }
}
