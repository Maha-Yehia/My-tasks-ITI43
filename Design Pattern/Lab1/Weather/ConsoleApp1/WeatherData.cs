using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class WeatherData
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public delegate void WeatherDataDelegate(float tempreature, float humidity, float pressure);
        public event WeatherDataDelegate ChangeWeatherMeasurements;

        protected virtual void onChangeWeatherMeasurements()
        {
            //notify subs.
            ChangeWeatherMeasurements?.Invoke(_temperature, _humidity, _pressure);
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            onChangeWeatherMeasurements();
        }

        public float Temperature
        {
            get { return _temperature; }
        }

        public float Humidity
        {
            get { return _humidity; }
        }

        public float Pressure
        {
            get { return _pressure; }
        }

    }
}
