using System;

interface IProduct
{
    string GetInfo();
}

class ProductA : IProduct
{
    public string GetInfo() => "Продукт A";
}

class ProductB : IProduct
{
    public string GetInfo() => "Продукт B";
}

abstract class Creator
{
    public abstract IProduct FactoryMethod();
}

class CreatorA : Creator
{
    public override IProduct FactoryMethod() => new ProductA();
}

class CreatorB : Creator
{
    public override IProduct FactoryMethod() => new ProductB();
}

class Program
{
    static void Main()
    {
        Console.WriteLine(new CreatorA().FactoryMethod().GetInfo());
        Console.WriteLine(new CreatorB().FactoryMethod().GetInfo());
    }
}
