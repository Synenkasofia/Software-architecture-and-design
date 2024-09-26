using System;

// Інтерфейс реалізації
interface IDrawingAPI
{
    void DrawCircle(double x, double y, double radius);
}

// Реалізації
class DrawingAPI1 : IDrawingAPI
{
    public void DrawCircle(double x, double y, double radius) =>
        Console.WriteLine($"API1: Circle at ({x}, {y}) radius {radius}");
}

class DrawingAPI2 : IDrawingAPI
{
    public void DrawCircle(double x, double y, double radius) =>
        Console.WriteLine($"API2: Circle at ({x}, {y}) radius {radius}");
}

// Абстракція
abstract class Shape
{
    protected IDrawingAPI _drawingAPI;
    protected Shape(IDrawingAPI drawingAPI) => _drawingAPI = drawingAPI;
    public abstract void Draw();
}

// Конкретна абстракція
class Circle : Shape
{
    double _x, _y, _radius;
    public Circle(double x, double y, double radius, IDrawingAPI drawingAPI) : base(drawingAPI)
    {
        _x = x; _y = y; _radius = radius;
    }
    public override void Draw() => _drawingAPI.DrawCircle(_x, _y, _radius);
}

class Program
{
    static void Main()
    {
        var circle1 = new Circle(5, 10, 2, new DrawingAPI1());
        var circle2 = new Circle(15, 20, 3, new DrawingAPI2());
        circle1.Draw();
        circle2.Draw();
    }
}
