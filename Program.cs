using System;

var games = new List<string>();

string name = GetName();
var date = DateTime.UtcNow;

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");
    string name = Console.ReadLine();
    return name;
}

void Menu(string name)
{
    Console.WriteLine("--------------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game.");
    Console.WriteLine("\n");

    bool isGameOn = true;

    do
    {
        Console.Clear();
        Console.WriteLine($@"What game would you like to play today? Choose from the options below:
                                A - Addition
                                S - Subtraction
                                M - Multiplication 
                                D - Division
                                Press Q or type Quit at anytime to exit the program.");
        Console.WriteLine("--------------------------------------");

        var gameSelected = Console.ReadLine();

        switch (gameSelected.Trim().ToLower())
        {
            case "v":
                GetGames();
                break;
            case "a":
                AdditionGame("Addition game");
                break;
            case "s":
                SubtractionGame("Subtraction game");
                break;
            case "m":
                MultiplicationGame("Multiplication game");
                break;
            case "d":
                DivisionGame("Division game");
                break;
            case "q":
                Console.WriteLine("Goodbye");
                break;
            default:
                Console.WriteLine("Invalid input");
                isGameOn = false;
                break;

        }
    } while (isGameOn);



}

void GetGames()
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

void AdditionGame(string message)
{
    var score = 0;

    var random = new Random();

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} + {secondNumber}");

        var result = Console.ReadLine();

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

    games.Add($"{DateTime.Now} - Addition: Score={score} "); // Logs the game played and the score into the list declared "games" 

}

void SubtractionGame(string message)
{

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Your answer was correct");
            score++;
        }
        else
        {
            Console.WriteLine("Your answwer was incorrect");
        }

        if (i == 1) Console.WriteLine($"Your score was {score} points");
    }


}
void MultiplicationGame(string message)
    {
        var score = 0;

        var random = new Random();

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
            Console.WriteLine($"{firstNumber} * {secondNumber}");

            var result = Console.ReadLine();

            if (int.Parse(result) == firstNumber * secondNumber) // parse string into integer
            {
                Console.WriteLine("Your answer was correct");
                score++;
            }
            else
            {
                Console.WriteLine("Your answer was incorrect");
            }

            if (i == 4) Console.WriteLine($"Your score was {score} points");


        }
    }

void DivisionGame(string message)
{
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct. Type any key for the next question");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for the next question");
            Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Your score was {score} points");


    }
}


int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(1, 99);
    var secondNumber = random.Next(1, 99);

    var result = new int[2];

    while (firstNumber % secondNumber !=0) // while the first number divided by the second number is not equal to zero, keep generating random numbers
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber; // this means the first number is the first element in the array
    result[1] = secondNumber; // this means the second number is the second element in the array

    return result;

}




