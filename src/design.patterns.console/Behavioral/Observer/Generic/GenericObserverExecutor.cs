namespace design.patterns.console.Behavioral.Observer.Generic;

public static class GenericObserverExecutor
{
    public static void Execute()
    {
        var observer1 = new Observer("observer1");
        var observer2 = new Observer("observer2");

        var subject = new Subject();
        subject.Subscribe(observer1);
        subject.Subscribe(observer2);
        
        subject.Notify();
    }
}