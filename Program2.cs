
//Isp


using System;

interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

class Bird : IFlyable
{
    public void Fly() => Console.WriteLine("Птах летить");
}

class Fish : ISwimmable
{
    public void Swim() => Console.WriteLine("Риба плаває");
}

class Duck : IFlyable, ISwimmable
{
    public void Fly() => Console.WriteLine("Качка летить");
    public void Swim() => Console.WriteLine("Качка плаває");
}

class Program
{
    static void Main()
    {
        new Bird().Fly();
        new Fish().Swim();
        new Duck().Fly();
        new Duck().Swim();
    }
}



