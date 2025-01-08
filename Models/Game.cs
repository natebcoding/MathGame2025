namespace MathGame2025.Models;

internal class Game
{

    internal DateTime Date { get; set; }

    internal int Score { get; set; }

    internal GameType Type { get; set; }

    internal DifficultyLevel Difficulty { get; set; }


}

internal enum GameType 
{
    Addition,
    Subtraction,
    Multiplication,
    Division, 
    Random
}

internal enum DifficultyLevel
{
    Easy,
    Medium,
    Hard
}