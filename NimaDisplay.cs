using HeadFirstObserverPatternSample.Abstractions;

namespace HeadFirstObserverPatternSample
{
    public class NimaDisplay : IObserver, IDisplayElement
    {
        private readonly WeatherData _weatherData;
        private float _temperature;
        private float _pressure;
        private float _humidity;

        public NimaDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;

            _weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _pressure = pressure;
            _humidity = humidity;

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Nima Display Now Says: temperature is {_temperature}, pressure is {_pressure} and humidity is {_humidity}\n\r");
        }
    }
}
