using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    internal class Investor : IObserver
    {
        public void Update(ISubject subject)
        {
            OnValueChanged(subject.GetName(), subject.GetValue());
        }

        void OnValueChanged(string name, float value)
        {
            Console.WriteLine($"{name} is now valued at {value} Euro.");
        }

    }
}
