namespace HeadFirstObserverPatternSample.Abstractions
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
