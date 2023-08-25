namespace design.patterns.console.Behavioral.Strategy.Real;

public static class RealStrategyExecutor
{
    public static void Execute(decimal orderPrice, IPaymentProcessor paymentProcessor)
    {
        var paymentContext = new PaymentContext(paymentProcessor);
        paymentContext.Process(orderPrice);
    }
}