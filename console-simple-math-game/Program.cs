using console_simple_math_game;

var menu = new Menu();

var date = DateTime.UtcNow;

var games = new List<string>();

string name = Helpers.GetName();

menu.ShowMenu(name, date);


