namespace design.patterns.console.Behavioral.Strategy.Generic;

public class Context
{
    private IStrategy Strategy { get; set; }

    public Context(IStrategy strategy)
    {
        Strategy = strategy;
    }

    public void DoSomething()
    {
        Strategy.Execute();
    }
}