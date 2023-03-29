using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class ForecastDisplay
    {
        private float _currentPressure = 29.92f;
        private float _lastPressure;

        //public void Update(object subject)
        //{
        //    if (subject is WeatherData)
        //    {
        //        WeatherData weatherData = (WeatherData)subject;
        //        _lastPressure = _currentPressure;
        //        _currentPressure = weatherData.Pressure;
        //        Display();
        //    }
        //}
        public void Update(float temperature, float humidity, float pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.Write("Forecast: ");
            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (_currentPressure < _lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }
    }
}
