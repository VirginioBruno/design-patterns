namespace design.patterns.console.Behavioral.Observer.Real;

public static class RealObserverExecutor
{
    public static void Execute()
    {
        var weatherStation = new WeatherStation();
        var display1 = new WeatherDisplay("display1");
        var display2 = new WeatherDisplay("display2");
        
        weatherStation.Subscribe(display1);
        weatherStation.Subscribe(display2);
        
        weatherStation.Notify();
    }
}