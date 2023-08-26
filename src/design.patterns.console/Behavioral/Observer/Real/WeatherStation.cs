namespace design.patterns.console.Behavioral.Observer.Real;

public class WeatherStation : ISubject
{
    private readonly List<IObserver> _observers = new();
    
    public void Subscribe(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        var data = new WeatherData()
        {
            Temperature = 25.5,
            Humidity = 60.2,
            Pressure = 1013.2
        };
        
        foreach (var observer in _observers)
        {
            observer.Update(data);
        }
    }
}