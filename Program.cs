using MathGame2025;

var menu = new Menu();

var games = new List<string>();

string name = Helpers.GetName();

var date = DateTime.UtcNow;

menu.ShowMenu(name, date);



