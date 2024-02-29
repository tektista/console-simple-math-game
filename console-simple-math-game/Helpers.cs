namespace console_simple_math_game;

internal class Helpers
{
    static List<string> games = new();
    
    internal static void AddToHistory(int gameScore, string gameType)
    {
        games.Add($"{DateTime.Now} - {gameType}: {gameScore} pts");   
    }
    
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
    
    internal static void GetGames()
    {
        foreach (var game in games)
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine(game);
            Console.WriteLine("Press any key to return to the Main Menu");
        }
    }
}