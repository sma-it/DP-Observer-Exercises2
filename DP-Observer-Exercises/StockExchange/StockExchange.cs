using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    internal class StockExchange
    {
        private string _name;
        private float _value = 0;

        public StockExchange(string name)
        {
            _name = name;
        }

        public void Update(float newValue)
        {
            if (newValue != _value)
            {
                _value = newValue;
            }
        }

    }
}
