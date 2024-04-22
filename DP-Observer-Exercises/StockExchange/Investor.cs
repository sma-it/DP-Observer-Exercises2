using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    internal class Investor
    {
        void OnValueChanged(string name, float value)
        {
            Console.WriteLine($"{name} is now valued at {value} Euro.");
        }

    }
}
