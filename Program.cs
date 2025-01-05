using MathGame2025;

var menu = new Menu();

var games = new List<string>();

string name = GetName();

var date = DateTime.UtcNow;

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type your name");
    string name = Console.ReadLine();
    return name;
}

