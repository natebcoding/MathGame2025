using MathGame2025;
using MathGame2025.Models;

namespace MathGame2025
{
    public class Helpers
    {
        internal static List<Game> games = new List<Game>
        {
        new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
        new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
        new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
        new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
        new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
        };
        internal static void GetGames()
        {
            var gamesToPrint = games.Where(x => x.Date > new DateTime(2025, 01, 01)).OrderByDescending(x => x.Score); // This will filter the games list to only show the games that are of type Division
             

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("-----------------");
            foreach (var game in gamesToPrint)
            {
                Console.WriteLine($"{game.Date} - {game.Type} - {game.Score}pts");
            }
            Console.WriteLine("-----------------\n");
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
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

        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.UtcNow,
                Score = gameScore,
                Type = gameType


            }); // Logs the game played and the score into the list declared "games" 
        }



    }
}
