using Weather;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            var currentConditions = new CurrentConditionsDisplay();
            var statisticsDisplay = new StatisticsDisplay();
            var forecastDisplay = new ForecastDisplay();
            var heatIndexDisplay = new HeatIndexDisplay();

            weatherData.ChangeWeatherMeasurements += currentConditions.Update;
            weatherData.ChangeWeatherMeasurements += statisticsDisplay.Update;
            weatherData.ChangeWeatherMeasurements += forecastDisplay.Update;
            weatherData.ChangeWeatherMeasurements += heatIndexDisplay.Update;


            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);


        }
    }
}