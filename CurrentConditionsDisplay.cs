using HeadFirstObserverPatternSample.Abstractions;

namespace HeadFirstObserverPatternSample
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private readonly WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_weatherData.Temperature}F degrees and {_weatherData.Humidity}% humidity\n\r");
        }
    }
}
