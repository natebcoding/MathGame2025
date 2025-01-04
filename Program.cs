using System;

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
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("Goodbye");
            break;
        default:
            Console.WriteLine("Invalid input");
            break;

    }
}

void AdditionGame(string message)
{
    Console.WriteLine(message);
    var score = 0;

    var random = new Random();

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} + {secondNumber}");

        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber) // parse string into integer
        {
            Console.WriteLine("Your answer was correct");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect");
        }

        if (i == 1) Console.WriteLine($"Your score was {score} points");


    }

  
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
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
        Console.WriteLine(message);
        var score = 0;

        var random = new Random();

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++)
        {
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
        Console.WriteLine("Division game selected");
    }
