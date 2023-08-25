namespace design.patterns.console.Behavioral.Strategy.Real;

public class PaymentContext
{
    private IPaymentProcessor PaymentProcessor { get; set; }

    public PaymentContext(IPaymentProcessor paymentProcessor)
    {
        PaymentProcessor = paymentProcessor;
    }

    public void Process(decimal orderPrice)
    {
        PaymentProcessor.Process(orderPrice);
    }
}