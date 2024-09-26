using System;

// Інтерфейси продуктів
interface IChair { string GetType(); }
interface ISofa { string GetType(); }

// Конкретні продукти
class ModernChair : IChair { public string GetType() => "Сучасний стілець"; }
class ModernSofa : ISofa { public string GetType() => "Сучасний диван"; }
class VictorianChair : IChair { public string GetType() => "Вікторіанський стілець"; }
class VictorianSofa : ISofa { public string GetType() => "Вікторіанський диван"; }

// Абстрактна фабрика
interface IFurnitureFactory { IChair CreateChair(); ISofa CreateSofa(); }

// Конкретні фабрики
class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new ModernChair();
    public ISofa CreateSofa() => new ModernSofa();
}

class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new VictorianChair();
    public ISofa CreateSofa() => new VictorianSofa();
}

class Program
{
    static void Main()
    {
        IFurnitureFactory factory = new ModernFurnitureFactory();
        Console.WriteLine(factory.CreateChair().GetType());
        Console.WriteLine(factory.CreateSofa().GetType());

        factory = new VictorianFurnitureFactory();
        Console.WriteLine(factory.CreateChair().GetType());
        Console.WriteLine(factory.CreateSofa().GetType());
    }
}
