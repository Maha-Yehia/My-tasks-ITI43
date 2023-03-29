using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class StatisticsDisplay
    {
        private float _maxTemp = 0.0f;
        private float _minTemp = 200;
        private float _tempSum = 0.0f;
        private int _numReadings;

        public void Update(float temperature, float humidity, float pressure)
        {
                float temp = temperature;
                _tempSum += temp;
                _numReadings++;

                if (temp > _maxTemp)
                {
                    _maxTemp = temp;
                }

                if (temp < _minTemp)
                {
                    _minTemp = temp;
                }

                Display();           
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (_tempSum / _numReadings)
                + "/" + _maxTemp + "/" + _minTemp);
        }
    }
}
