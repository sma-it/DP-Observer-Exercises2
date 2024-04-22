// See https://aka.ms/new-console-template for more information

var google = new StockExchange.StockExchange("Google");
var microsoft = new StockExchange.StockExchange("Microsoft");

var investor = new StockExchange.Investor();
google.Attach(investor);
microsoft.Attach(investor);

void ChangeGoogleValue()
{
    Console.Write("New Google Value: ");
    float value = float.Parse(Console.ReadLine());
    google.Update(value);
}

void ChangeMicrosoftValue()
{
    Console.Write("New Microsoft Value: ");
    float value = float.Parse(Console.ReadLine());
    microsoft.Update(value);
}

var menu = new SMUtils.Menu();

menu.AddOption('1', "Set Google Value", ChangeGoogleValue);
menu.AddOption('2', "Set Microsoft Value", ChangeMicrosoftValue);
menu.Start();

google.Detach(investor);
microsoft.Detach(investor);