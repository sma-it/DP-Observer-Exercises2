using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class TemperatureDisplay : IObserver
    {
        ISubject _subject;

        public TemperatureDisplay(ISubject subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        ~TemperatureDisplay()
        {
            _subject.Detach(this);
        }

        public void Update(ISubject subject)
        {
            DisplayTemperature(subject.GetTemperature());
        }
        void DisplayTemperature(float temperature)
        {
            Console.WriteLine($"TemperatureDisplay - The temperature is now {temperature}");
        }
    }
}
