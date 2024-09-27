using System;

public interface IVisitor
{
    void Visit(ElementA elementA);
    void Visit(ElementB elementB);
}

public interface IElement
{
    void Accept(IVisitor visitor);
}

public class ElementA : IElement
{
    public void Accept(IVisitor visitor) => visitor.Visit(this);
    public string ExclusiveMethodA() => "Метод для A";
}

public class ElementB : IElement
{
    public void Accept(IVisitor visitor) => visitor.Visit(this);
    public string ExclusiveMethodB() => "Метод для B";
}

public class ConcreteVisitor : IVisitor
{
    public void Visit(ElementA elementA) => Console.WriteLine(elementA.ExclusiveMethodA());
    public void Visit(ElementB elementB) => Console.WriteLine(elementB.ExclusiveMethodB());
}

class Program
{
    static void Main()
    {
        IElement[] elements = { new ElementA(), new ElementB() };
        IVisitor visitor = new ConcreteVisitor();

        foreach (var element in elements)
        {
            element.Accept(visitor);
        }
    }
}
