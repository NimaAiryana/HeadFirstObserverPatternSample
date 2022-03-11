using HeadFirstObserverPatternSample;

Console.WriteLine("Hello, HeadFirst Observer Pattern :D");
Console.WriteLine();
Console.WriteLine();

var weatherData = new WeatherData();
new CurrentConditionsDisplay(weatherData);
new NimaDisplay(weatherData);

weatherData.SetMeasurements(10, 10, 10);
weatherData.SetMeasurements(10, 20, 30);
weatherData.SetMeasurements(30, 40, 50);
