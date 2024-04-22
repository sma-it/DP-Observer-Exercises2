using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class WeatherStation
    {
        private float temperature;
        private float humidity;

        public void ChangeWeather(float temperature, float humidity)
        {
            this.temperature = temperature;
            this.humidity = humidity;
        }
    }
}
