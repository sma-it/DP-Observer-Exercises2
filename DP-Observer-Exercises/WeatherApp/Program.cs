// See https://aka.ms/new-console-template for more information

var station = new WeatherApp.WeatherStation();

var display1 = new WeatherApp.TemperatureDisplay(station);
var display2 = new WeatherApp.HumidityDisplay(station);
var display3 = new WeatherApp.TotalDisplay(station);

void EnterValues()
{
    Console.Write("Temperature: ");
    float temperature = float.Parse(Console.ReadLine());

    Console.Write("Humidity: ");
    float humidity = float.Parse(Console.ReadLine());

    station.ChangeWeather(temperature, humidity);
}

var menu = new SMUtils.Menu();

menu.AddOption('1', "Set values", EnterValues);
menu.Start();