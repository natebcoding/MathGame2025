using System.ComponentModel.Design;
using System.Diagnostics;

namespace MathGame2025
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {

            Stopwatch stopWatch = new Stopwatch();


            int defaultMin = 1;
            int defaultMax = 9;
            bool difficulty = false;
            Models.DifficultyLevel selectedDifficulty = Models.DifficultyLevel.Easy;


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
                        selectedDifficulty = Models.DifficultyLevel.Easy;
                        break;
                    case "medium":
                        defaultMin = 10;
                        defaultMax = 99;
                        selectedDifficulty = Models.DifficultyLevel.Medium;
                        break;
                    case "hard":
                        defaultMin = 100;
                        defaultMax = 999;
                        selectedDifficulty = Models.DifficultyLevel.Hard;
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
                stopWatch.Start();
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
                    stopWatch.Stop();
                    TimeSpan elapsedTime = stopWatch.Elapsed;
                    string elapsedTimeRec = String.Format("{0:00}:{1:00}:2:00.{3:00}", elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.Milliseconds / 10);
                    Console.WriteLine($"Your score was {score} points. Elapsed Time: {elapsedTimeRec}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                    Helpers.AddToHistory(score, Models.GameType.Addition, selectedDifficulty, elapsedTime);
                }


            }


        }
        internal void SubtractionGame(string message)
        {
            int defaultMin = 1;
            int defaultMax = 9;
            bool difficulty = false;
            Models.DifficultyLevel selectedDifficulty = Models.DifficultyLevel.Easy;

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
                        selectedDifficulty = Models.DifficultyLevel.Easy;
                        difficulty = true;
                        break;
                    case "medium":
                        defaultMin = 10;
                        defaultMax = 99;
                        selectedDifficulty = Models.DifficultyLevel.Medium;
                        difficulty = true;
                        break;
                    case "hard":
                        defaultMin = 100;
                        defaultMax = 999;
                        selectedDifficulty = Models.DifficultyLevel.Hard;
                        difficulty = true;
                        break;
                    default:
                        Console.WriteLine("Invalid difficulty selected. Please try again.");
                        Console.ReadLine();
                        break;
                }
              
                
                Stopwatch stopWatch = new Stopwatch();

                var random = new Random();
                var score = 0;

                int firstNumber;
                int secondNumber;




                for (int i = 0; i < 5; i++)
                {
                    Console.Clear();
                    stopWatch.Start();
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


                    if (i == 4) {            
                        stopWatch.Stop();
                        TimeSpan elapsedTime = stopWatch.Elapsed;
                        string elapsedTimeRec = String.Format("{0:00}:{1:00}:2:00.{3:00}", elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.Milliseconds / 10);
                        Console.WriteLine($"Your score was {score} points. Elapsed Time: {elapsedTimeRec}. Press any key to go back to the main menu.");
                        Console.ReadLine();
                        Helpers.AddToHistory(score, Models.GameType.Addition, selectedDifficulty, elapsedTime);
                    }
                }

                

            }
        }
        internal void MultiplicationGame(string message)
        {

            int defaultMin = 1;
            int defaultMax = 9;
            bool difficulty = false;
            Models.DifficultyLevel selectedDifficulty = Models.DifficultyLevel.Easy;

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
                        selectedDifficulty = Models.DifficultyLevel.Easy;
                        difficulty = true;
                        break;
                    case "medium":
                        defaultMin = 10;
                        defaultMax = 99;
                        selectedDifficulty = Models.DifficultyLevel.Medium;
                        difficulty = true;
                        break;
                    case "hard":
                        defaultMin = 100;
                        defaultMax = 999;
                        selectedDifficulty = Models.DifficultyLevel.Hard;
                        difficulty = true;
                        break;
                    default:
                        Console.WriteLine("Invalid difficulty selected. Please try again.");
                        Console.ReadLine();
                        break;
                }
            }

            Stopwatch stopWatch = new Stopwatch();

            var score = 0;

            var random = new Random();

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                stopWatch.Start();
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

                if (i == 4)
                {
                    stopWatch.Stop();
                    TimeSpan elapsedTime = stopWatch.Elapsed;
                    string elapsedTimeRec = String.Format("{0:00}:{1:00}:2:00.{3:00}", elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.Milliseconds / 10);
                    Console.WriteLine($"Your score was {score} points. Elapsed Time: {elapsedTimeRec}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                    Helpers.AddToHistory(score, Models.GameType.Addition, selectedDifficulty, elapsedTime);
                }


            }

        }

        internal void DivisionGame(string message)
        {
            Stopwatch stopWatch = new Stopwatch();
            var score = 0;
            Models.DifficultyLevel selectedDifficulty = Models.DifficultyLevel.Easy;

            for (int i = 0; i < 5; i++)
            {

                Console.Clear();
                stopWatch.Start();
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

                if (i == 4)
                {
                    stopWatch.Stop();
                    TimeSpan elapsedTime = stopWatch.Elapsed;
                    string elapsedTimeRec = String.Format("{0:00}:{1:00}:2:00.{3:00}", elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.Milliseconds / 10);
                    Console.WriteLine($"Your score was {score} points. Elapsed Time: {elapsedTimeRec}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                    Helpers.AddToHistory(score, Models.GameType.Addition, selectedDifficulty, elapsedTime);
                }


            }
        }

        internal void RandomGame(string message)
        {
            Stopwatch stopWatch = new Stopwatch();
            int defaultMin = 1;
            int defaultMax = 9;
            bool difficulty = false;
            Models.DifficultyLevel selectedDifficulty = Models.DifficultyLevel.Easy;

            while (!difficulty)
            {
                Console.WriteLine("What difficulty level would you like?");
                Console.WriteLine("Easy, Medium or Hard?");
                string difficultyLevel = Console.ReadLine()?.ToLower();

                switch (difficultyLevel)
                {
                    case "easy":
                        defaultMin = 1;
                        defaultMax = 9;
                        selectedDifficulty = Models.DifficultyLevel.Easy;
                        difficulty = true;
                        break;
                    case "medium":
                        defaultMin = 10;
                        defaultMax = 99;
                        selectedDifficulty = Models.DifficultyLevel.Medium;
                        difficulty = true;
                        break;
                    case "hard":
                        defaultMin = 100;
                        defaultMax = 999;
                        selectedDifficulty = Models.DifficultyLevel.Hard;
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

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                stopWatch.Start();
                Console.WriteLine(message);

                int firstNumber = random.Next(defaultMin, defaultMax);
                int secondNumber = random.Next(defaultMin, defaultMax);
                string question = "";
                int ValidateAnswer = 0;

                var gameType = (Models.GameType)random.Next(0, 4); 

                switch (gameType)
                {
                    case Models.GameType.Addition:
                        question = $"{firstNumber} + {secondNumber}";
                        ValidateAnswer = firstNumber + secondNumber;
                        break;
                    case Models.GameType.Subtraction:
                        question = $"{firstNumber} - {secondNumber}";
                        ValidateAnswer = firstNumber - secondNumber;
                        break;
                    case Models.GameType.Multiplication:
                        question = $"{firstNumber} * {secondNumber}";
                        ValidateAnswer = firstNumber * secondNumber;
                        break;
                    case Models.GameType.Division:
                        secondNumber = random.Next(1, defaultMax);
                        firstNumber = secondNumber * random.Next(defaultMin, defaultMax / secondNumber);
                        question = $"{firstNumber} / {secondNumber}";
                        ValidateAnswer = firstNumber / secondNumber;
                        break;
                }

                Console.WriteLine(question);
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == ValidateAnswer)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                }

                Console.ReadKey();
            }


            stopWatch.Stop();
            TimeSpan elapsedTime = stopWatch.Elapsed;
            string elapsedTimeRec = String.Format("{0:00}:{1:00}:2:00.{3:00}", elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.Milliseconds / 10);
            Console.WriteLine($"Your score was {score} points. Elapsed Time: {elapsedTimeRec}. Press any key to go back to the main menu.");
            Console.ReadLine();
            Helpers.AddToHistory(score, Models.GameType.Addition, selectedDifficulty, elapsedTime);
        }
    }

}
