using System;

public interface IStrategy
{
    void Execute();
}

public class StrategyA : IStrategy
{
    public void Execute() => Console.WriteLine("Виконання стратегії A.");
}

public class StrategyB : IStrategy
{
    public void Execute() => Console.WriteLine("Виконання стратегії B.");
}

public class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy) => _strategy = strategy;

    public void SetStrategy(IStrategy strategy) => _strategy = strategy;

    public void ExecuteStrategy() => _strategy.Execute();
}

class Program
{
    static void Main()
    {
        var context = new Context(new StrategyA());
        context.ExecuteStrategy(); // Виконання стратегії A

        context.SetStrategy(new StrategyB());
        context.ExecuteStrategy(); // Виконання стратегії B
    }
}
