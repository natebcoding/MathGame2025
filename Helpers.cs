

namespace MathGame2025
{
    internal class Helpers
    {
        static List<string> games = new();
        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("-----------------");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("-----------------\n");
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }


        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: Score = {gameScore}"); // Logs the game played and the score into the list declared "games" 
        }



        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0) // while the first number divided by the second number is not equal to zero, keep generating random numbers
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber; // this means the first number is the first element in the array
            result[1] = secondNumber; // this means the second number is the second element in the array

            return result;

        }
    }
}
