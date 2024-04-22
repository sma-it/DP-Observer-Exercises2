using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class WeatherStation : ISubject
    {
        private float temperature;
        private float humidity;

        List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void ChangeWeather(float temperature, float humidity)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            notify();
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public float GetHumidity()
        {
            return humidity;
        }

        public float GetTemperature()
        {
            return temperature;
        }

        void notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
