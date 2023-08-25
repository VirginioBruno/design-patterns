namespace design.patterns.console.Behavioral.Strategy.Real;

public interface IPaymentProcessor
{
    public void Process(decimal orderPrice);
}