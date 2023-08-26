namespace design.patterns.console.Behavioral.Observer.Generic;

public interface IObserver
{
    public string Name { get; set; }
    public void Update(string data);
}