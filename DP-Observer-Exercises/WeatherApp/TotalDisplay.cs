﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class TotalDisplay
    {
        void Display(float temperature, float humidity)
        {
            Console.WriteLine($"TotalDisplay - Humidity: {humidity} Temperature: {temperature}");
        }
    }
}
