using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class CurrentConditionsDisplay
    {
        private float _temperature;
        private float _humidity;


        public void Update(float temperature, float humidity, float pressure)
        {
            //if (subject is WeatherData)
            //{
            //    WeatherData weatherData = (WeatherData)subject;
            //this._temperature = weatherData.Temperature;
            //this._humidity = weatherData.Humidity;
            //Display();
            //}
            this._temperature = temperature;
            this._humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature
                + "F degrees and " + _humidity + "% humidity");
        }
    }
}
