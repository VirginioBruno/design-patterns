namespace design.patterns.console.Behavioral.Strategy.Generic;

public static class GenericStrategyExecutor
{
    public static void Execute(IStrategy strategy)
    {
        var context = new Context(strategy);
        context.DoSomething();
    }
}