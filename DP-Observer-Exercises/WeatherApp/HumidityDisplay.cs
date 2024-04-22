using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class HumidityDisplay : IObserver
    {
        ISubject _subject;

        public HumidityDisplay(ISubject subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        ~HumidityDisplay()
        {
            _subject.Detach(this);
        }

        public void Update(ISubject subject)
        {
            DisplayHumidity(subject.GetHumidity());
        }

        void DisplayHumidity(float humidity)
        {
            Console.WriteLine($"HumidityDisplay - The humidity is now {humidity}");   
        }
    }
}
