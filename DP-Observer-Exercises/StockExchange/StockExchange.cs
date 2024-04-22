using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    internal class StockExchange : ISubject
    {
        private string _name;
        private float _value = 0;
        private List<IObserver> _observers = new List<IObserver>(); 

        public StockExchange(string name)
        {
            _name = name;
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public string GetName()
        {
            return _name;
        }

        public float GetValue()
        {
            return _value;
        }

        public void Update(float newValue)
        {
            if (newValue != _value)
            {
                _value = newValue;
                Notify();
            }
        }

        void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }

    }
}
