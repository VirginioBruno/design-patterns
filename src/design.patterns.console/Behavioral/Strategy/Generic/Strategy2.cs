namespace design.patterns.console.Behavioral.Strategy.Generic;

public class Strategy2 : IStrategy
{
    public void Execute()
    {
        Console.WriteLine($"Called {nameof(Strategy2)}");
    }
}