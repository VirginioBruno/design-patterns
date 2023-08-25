namespace design.patterns.console.Behavioral.Strategy.Generic;

public class Strategy1 : IStrategy
{
    public void Execute()
    {
        Console.WriteLine($"Called {nameof(Strategy1)}");
    }
}