using System;

// Продукт
class Product
{
    public string PartA, PartB, PartC;
    public override string ToString() => $"Product with {PartA}, {PartB}, {PartC}";
}

// Будівельник
interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
    Product GetResult();
}

// Конкретний будівельник
class ConcreteBuilder : IBuilder
{
    private Product _product = new Product();
    public void BuildPartA() => _product.PartA = "PartA";
    public void BuildPartB() => _product.PartB = "PartB";
    public void BuildPartC() => _product.PartC = "PartC";
    public Product GetResult() => _product;
}

// Директор
class Director
{
    private readonly IBuilder _builder;
    public Director(IBuilder builder) => _builder = builder;
    public void Construct() { _builder.BuildPartA(); _builder.BuildPartB(); _builder.BuildPartC(); }
}

class Program
{
    static void Main()
    {
        var builder = new ConcreteBuilder();
        var director = new Director(builder);
        director.Construct();
        Console.WriteLine(builder.GetResult());
    }
}
