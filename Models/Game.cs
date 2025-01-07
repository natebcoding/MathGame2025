namespace MathGame2025.Models;

internal class Game
{
    // private int _score; // private field to store the score
    // get {  return _score; } // this is the getter method that returns the value of the score
    // set { _score = value; } // this is the setter method that sets the value of the score
    // The point of this is to encapsulate the score field and make it private so that it can only be accessed through the getter and setter methods    
    // New way below: 

    internal DateTime Date { get; set; }

    internal int Score { get; set; }

    internal GameType Type { get; set; }

}

internal enum GameType 
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}