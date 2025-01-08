// Challenges
// [X]Try to implement levels of difficulty
// [ ] Add a timer to track how long the user takes to finish the game
// [x] Create a 'Random Game' option where the players will be presented with questions from random operations


using MathGame2025;

var menu = new Menu();

var games = new List<string>();

string name = Helpers.GetName();

var date = DateTime.UtcNow;

menu.ShowMenu(name, date);



