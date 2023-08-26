namespace design.patterns.console.Behavioral.Observer.Generic;

public class Subject : ISubject
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
        foreach (var observer in _observers)
        {
            observer.Update("Notified");
        }
    }
}