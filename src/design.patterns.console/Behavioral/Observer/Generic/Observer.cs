namespace design.patterns.console.Behavioral.Observer.Generic;

public class Observer : IObserver
{
    public string Name { get; set; }

    public Observer(string name)
    {
        Name = name;
    }

    public void Update(string data)
    {
        Console.WriteLine($"The observer {Name} received data: {data}");
    }
}