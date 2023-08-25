namespace design.patterns.console.Behavioral.Strategy.Real;

public class CreditCard : IPaymentProcessor
{
    public void Process(decimal orderPrice)
    {
        Console.WriteLine($"Processing {orderPrice} on {nameof(CreditCard)}");
    }
}