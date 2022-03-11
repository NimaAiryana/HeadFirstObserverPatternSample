using HeadFirstObserverPatternSample.Abstractions;

namespace HeadFirstObserverPatternSample
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers = new();
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers) observer.Update(_temperature, _humidity, _pressure);
        }

        public void MeasurmentChanged() => NotifyObservers();

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;

            MeasurmentChanged();
        }
    }
}
