using System.Security.Cryptography;

namespace design.patterns.console.Behavioral.Observer.Real;

public interface IObserver
{
    public string Name { get; set; }
    public void Update(object data);
}