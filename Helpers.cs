using MathGame2025;
using MathGame2025.Models;
using System.Threading.Channels;

namespace MathGame2025
{
    public class Helpers
    {
        internal static List<Game> games = new List<Game>
        {
        // Sample data to test filters
        /*new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
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
        new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },*/
        };
        internal static void GetGames()
        {
            var gamesToPrint = games.Where(x => x.Date > new DateTime(2025, 01, 01)).OrderByDescending(x => x.Score); // This will filter the games list to only show the games that are of type Division
             

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("-----------------");
            foreach (var game in gamesToPrint)
            {
                Console.WriteLine($"{game.Date} - {game.Difficulty} - {game.Type} - {game.Score}pts");
            }
            Console.WriteLine("-----------------\n");
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }

        internal static int[] GetDivisionNumbers()
        {
            int defaultMin = 1;
            int defaultMax = 9;
            bool difficulty = false;
            DifficultyLevel selectedDifficulty = DifficultyLevel.Easy;

            while (!difficulty)
            {
                Console.WriteLine("What difficulty level would you like?");
                Console.WriteLine("Easy, Medium or Hard?");
                string difficultyLevel = Console.ReadLine();

                switch (difficultyLevel)
                {
                    case "easy":
                        defaultMin = 1;
                        defaultMax = 99;
                        selectedDifficulty = DifficultyLevel.Easy;
                        difficulty = true;
                        break;
                    case "medium":
                        defaultMin = 99;
                        defaultMax = 500;
                        selectedDifficulty = DifficultyLevel.Medium;
                        difficulty = true;
                        break;
                    case "hard":
                        defaultMin = 500;
                        defaultMax = 999;
                        selectedDifficulty = DifficultyLevel.Hard;
                        difficulty = true;
                        break;
                    default:
                        Console.WriteLine("Invalid difficulty selected. Please try again.");
                        Console.ReadLine();
                        break;
                }
            }

            var random = new Random();
            var firstNumber = random.Next(defaultMin, defaultMax);
            var secondNumber = random.Next(defaultMin, defaultMax);

            var result = new int[2];

            while (firstNumber % secondNumber != 0) // while the first number divided by the second number is not equal to zero, keep generating random numbers
            {
                firstNumber = random.Next(defaultMin, defaultMax);
                secondNumber = random.Next(defaultMin, defaultMax);
            }

            result[0] = firstNumber; // this means the first number is the first element in the array
            result[1] = secondNumber; // this means the second number is the second element in the array

            return result;

        }

        internal static void AddToHistory(int gameScore, GameType gameType, DifficultyLevel difficulty)
        {
            games.Add(new Game
            {
                Date = DateTime.UtcNow,
                Score = gameScore,
                Type = gameType,
                Difficulty = difficulty



            }); 
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !int.TryParse(result, out _)) 
            {
                Console.WriteLine("Your answer must be an integer. Please try again");
                result = Console.ReadLine();
            }
                return result;
        }

        internal static string GetName()
        {
            Console.WriteLine("Please type your name");
            string name = Console.ReadLine();

            while (string.IsNullOrEmpty(name)) // while the name is empty, keep asking for the name
            {
                Console.WriteLine("Your name cannot be empty. Please type your name");
                name = Console.ReadLine();
            }
            return name;
        }

        
    }
}
