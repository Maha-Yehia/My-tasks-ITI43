using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class HeatIndexDisplay
    {
        private float _heatIndex = 0.0f;
        public void Update(float temperature, float humidity, float pressure)
        {
                float t = temperature;
                float rh = humidity;
                _heatIndex = (float)
                    (
                    (16.923 + (0.185212 * t)) +
                    (5.37941 * rh) -
                    (0.100254 * t * rh) +
                    (0.00941695 * (t * t)) +
                    (0.00728898 * (rh * rh)) +
                    (0.000345372 * (t * t * rh)) -
                    (0.000814971 * (t * rh * rh)) +
                    (0.0000102102 * (t * t * rh * rh)) -
                    (0.000038646 * (t * t * t)) +
                    (0.0000291583 * (rh * rh * rh)) +
                    (0.00000142721 * (t * t * t * rh)) +
                    (0.000000197483 * (t * rh * rh * rh)) -
                    (0.0000000218429 * (t * t * t * rh * rh)) +
                    (0.000000000843296 * (t * t * rh * rh * rh)) -
                    (0.0000000000481975 * (t * t * t * rh * rh * rh)));
                Display();
            
        }


        public void Display()
        {
            Console.WriteLine("Heat index is " + _heatIndex + "\n");
        }
    }
}
