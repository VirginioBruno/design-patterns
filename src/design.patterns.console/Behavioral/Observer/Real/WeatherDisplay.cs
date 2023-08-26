namespace design.patterns.console.Behavioral.Observer.Real;

public class WeatherDisplay : IObserver
{
    public string Name { get; set; }

    public WeatherDisplay(string displayName)
    {
        Name = displayName;
    }

    public void Update(object data)
    {
        if (data is WeatherData weatherData)
        {
            Console.WriteLine($"{Name} Display - Temperature: {weatherData.Temperature}°C, Humidity: {weatherData.Humidity}%, Pressure: {weatherData.Pressure} hPa");
        }
    }
}