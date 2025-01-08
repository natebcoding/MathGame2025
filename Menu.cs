

namespace MathGame2025
{
    internal class Menu
    {
        GameEngine engine = new GameEngine(); 
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. Welcome to the Math Game.");
            Console.ReadLine();
            Console.WriteLine("\n");

            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
                                V - View games history
                                A - Addition
                                S - Subtraction
                                M - Multiplication 
                                D - Division
                                R - Random
                                Press Q or type Quit at anytime to exit the program.");
                Console.WriteLine("--------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        engine.AdditionGame("Addition game");
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        engine.DivisionGame("Division game");
                        break;
                    case "r":
                        engine.RandomGame("Random game");
                        break;
                    case "quit":
                    case "q":
                        Console.WriteLine("Goodbye");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        isGameOn = false;
                        break;

                }
            } while (isGameOn);



        }
    }
}
