using System;

// Підсистема A
class SubsystemA
{
    public void OperationA() => Console.WriteLine("Subsystem A: Operation A");
}

// Підсистема B
class SubsystemB
{
    public void OperationB() => Console.WriteLine("Subsystem B: Operation B");
}

// Фасад
class Facade
{
    private SubsystemA _subsystemA = new SubsystemA();
    private SubsystemB _subsystemB = new SubsystemB();

    public void Operation()
    {
        _subsystemA.OperationA();
        _subsystemB.OperationB();
    }
}

class Program
{
    static void Main()
    {
        var facade = new Facade();
        facade.Operation();
    }
}
