using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class TotalDisplay : IObserver
    {
        ISubject _subject;

        public TotalDisplay(ISubject subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        ~TotalDisplay()
        {
            _subject.Detach(this);
        }

        public void Update(ISubject subject)
        {
            Display(subject.GetTemperature(), subject.GetHumidity());
        }

        void Display(float temperature, float humidity)
        {
            Console.WriteLine($"TotalDisplay - Humidity: {humidity} Temperature: {temperature}");
        }
    }
}
