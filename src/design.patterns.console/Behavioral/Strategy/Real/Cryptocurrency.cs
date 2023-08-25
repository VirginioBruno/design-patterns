namespace design.patterns.console.Behavioral.Strategy.Real;

public class Cryptocurrency : IPaymentProcessor
{
    public void Process(decimal orderPrice)
    {
        Console.WriteLine($"Processing {orderPrice} on {nameof(Cryptocurrency)}");
    }
}