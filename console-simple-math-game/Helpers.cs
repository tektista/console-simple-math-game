namespace console_simple_math_game;
using console_simple_math_game.Models;

internal class Helpers
{
    internal static List<Game> games = new List<Game>();
    
    internal static int[] GetDivisionNumbers()
    {
        var random = new Random();
        var firstNumber = random.Next(0, 99);
        var secondNumber = random.Next(0, 99);

        var result = new int[2];
    
        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(0, 99);
            secondNumber = random.Next(0, 99);
        }

        result[0] = firstNumber;
        result[1] = secondNumber;
    
        return result;
    }
    internal static void AddToHistory(int gameScore, GameType gameType)
    {
        games.Add( new Game {
            Date = DateTime.Now,
            Score = gameScore,
            Type = gameType,
        });   
    }
    
    internal static void PrintGames()
    {
        foreach (var game in games)
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
            Console.WriteLine("Press any key to return to the Main Menu");
        }
    }
}