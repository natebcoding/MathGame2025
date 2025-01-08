using System.ComponentModel.Design;

namespace MathGame2025
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            int defaultMin = 1;
            int defaultMax = 9;
            bool difficulty = false;

            while (!difficulty)
            {
                Console.WriteLine("What difficulty level would you like?");
                Console.WriteLine("Easy, Medium or Hard?");
                string difficultyLevel = Console.ReadLine();

                switch (difficultyLevel)
                {
                    case "easy":
                        defaultMin = 1;
                        defaultMax = 9;
                        difficulty = true;
                        break;
                    case "medium":
                        defaultMin = 10;
                        defaultMax = 99;
                        difficulty = true;
                        break;
                    case "hard":
                        defaultMin = 100;
                        defaultMax = 999;
                        difficulty = true;
                        break;
                    default:
                        Console.WriteLine("Invalid difficulty selected. Please try again.");
                        Console.ReadLine();
                        break;
                }
            }
            var score = 0;

            var random = new Random();

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
            
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(defaultMin, defaultMax);
                secondNumber = random.Next(defaultMin, defaultMax);
                Console.WriteLine($"{firstNumber} + {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber) // parse string into integer
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question");
                    score++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                }

                if (i == 4)
                {
                    Console.WriteLine($"Your score was {score} points. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }


            }
           Helpers.AddToHistory(score, Models.GameType.Addition);


        }
        internal void SubtractionGame(string message)
        {
            int defaultMin = 1;
            int defaultMax = 9;
            bool difficulty = false;

            while (!difficulty)
            {
                Console.WriteLine("What difficulty level would you like?");
                Console.WriteLine("Easy, Medium or Hard?");
                string difficultyLevel = Console.ReadLine();

                switch (difficultyLevel)
                {
                    case "easy":
                        defaultMin = 1;
                        defaultMax = 9;
                        difficulty = true;
                        break;
                    case "medium":
                        defaultMin = 10;
                        defaultMax = 99;
                        difficulty = true;
                        break;
                    case "hard":
                        defaultMin = 100;
                        defaultMax = 999;
                        difficulty = true;
                        break;
                    default:
                        Console.WriteLine("Invalid difficulty selected. Please try again.");
                        Console.ReadLine();
                        break;
                }


                var random = new Random();
                var score = 0;

                int firstNumber;
                int secondNumber;



                for (int i = 0; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(message);
                    firstNumber = random.Next(defaultMin, defaultMax);
                    secondNumber = random.Next(defaultMin, defaultMax);

                    Console.WriteLine($"{firstNumber} - {secondNumber}");
                    var result = Console.ReadLine();

                    result = Helpers.ValidateResult(result);

                    if (int.Parse(result) == firstNumber - secondNumber)
                    {
                        Console.WriteLine("Your answer was correct");
                        score++;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Your answwer was incorrect");
                    }


                    if (i == 4) Console.WriteLine($"Your score was {score} points");
                }

                Helpers.AddToHistory(score, Models.GameType.Subtraction);

            }
        }
        internal void MultiplicationGame(string message)
        {

            int defaultMin = 1;
            int defaultMax = 9;
            bool difficulty = false;

            while (!difficulty)
            {
                Console.WriteLine("What difficulty level would you like?");
                Console.WriteLine("Easy, Medium or Hard?");
                string difficultyLevel = Console.ReadLine();

                switch (difficultyLevel)
                {
                    case "easy":
                        defaultMin = 1;
                        defaultMax = 9;
                        difficulty = true;
                        break;
                    case "medium":
                        defaultMin = 10;
                        defaultMax = 99;
                        difficulty = true;
                        break;
                    case "hard":
                        defaultMin = 100;
                        defaultMax = 999;
                        difficulty = true;
                        break;
                    default:
                        Console.WriteLine("Invalid difficulty selected. Please try again.");
                        Console.ReadLine();
                        break;
                }
            }

            var score = 0;

            var random = new Random();

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(defaultMin, defaultMax);
                secondNumber = random.Next(defaultMin, defaultMax);
                Console.WriteLine($"{firstNumber} * {secondNumber}");


                var result = Console.ReadLine();
                
                result = Helpers.ValidateResult(result);


                if (int.Parse(result) == firstNumber * secondNumber) // parse string into integer
                {
                    Console.WriteLine("Your answer was correct");
                    score++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect");
                }

                if (i == 4) Console.WriteLine($"Your score was {score} points");


            }

            Helpers.AddToHistory(score, Models.GameType.Multiplication);
        }

        internal void DivisionGame(string message)
        {
            var score = 0;

            for (int i = 0; i < 5; i++)
            {



                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question");
                    score++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Your score was {score} points");


            }

            Helpers.AddToHistory(score, Models.GameType.Division);
        }

    }
}
