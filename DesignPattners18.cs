using System;

public abstract class AbstractClass
{
    // Шаблонний метод з фіксованою послідовністю кроків
    public void TemplateMethod()
    {
        Step1();
        Step2();
        Step3();
    }

    protected abstract void Step1();
    protected abstract void Step2();
    protected virtual void Step3() => Console.WriteLine("Крок 3 (за замовчуванням)");
}

public class ClassA : AbstractClass
{
    protected override void Step1() => Console.WriteLine("ClassA: Крок 1");
    protected override void Step2() => Console.WriteLine("ClassA: Крок 2");
}

public class ClassB : AbstractClass
{
    protected override void Step1() => Console.WriteLine("ClassB: Крок 1");
    protected override void Step2() => Console.WriteLine("ClassB: Крок 2");
    protected override void Step3() => Console.WriteLine("ClassB: Крок 3 (перевизначений)");
}

class Program
{
    static void Main()
    {
        AbstractClass classA = new ClassA();
        classA.TemplateMethod(); // Виклик для ClassA

        AbstractClass classB = new ClassB();
        classB.TemplateMethod(); // Виклик для ClassB
    }
}
