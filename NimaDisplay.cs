using HeadFirstObserverPatternSample.Abstractions;

namespace HeadFirstObserverPatternSample
{
    public class NimaDisplay : IObserver, IDisplayElement
    {
        private readonly WeatherData _weatherData;

        public NimaDisplay(WeatherData weatherData)
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
            Console.WriteLine($"Nima Display Now Says: temperature is {_weatherData.Temperature}, pressure is {_weatherData.Pressure} and humidity is {_weatherData.Humidity}\n\r");
        }
    }
}
