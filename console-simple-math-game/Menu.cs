namespace console_simple_math_game;

internal class Menu
{
    private GameEngine engine = new();
    internal void ShowMenu(string name, DateTime date)
    {
        Console.Clear();
        Console.WriteLine($"Hello {name}. It's {date}. This is your math's game. That's great that you're working on improving yourself \n");
        var isGameOn = true;

        do
        {
            Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");

            var gameSelected = Console.ReadLine();

            switch (gameSelected.Trim().ToLower())
            {
                case "v":
                    Helpers.GetGames();
                    break;
                case "a":
                    engine.AdditionGame("Addition game selected");
                    break;
                case "s":
                   engine. SubtractionGame("Subtraction game selected");
                    break;
                case "m":
                    engine.MultiplicationGame("Multiplication game selected");
                    break;
                case "d":
                    engine.DivisionGame("Division game selected");
                    break;
                case "q":
                    Console.WriteLine("Goodbye");
                    isGameOn = false;
                    break;
            }
        } while (isGameOn);

    }
    
}