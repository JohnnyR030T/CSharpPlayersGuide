// Ask Pilot to enter a number
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

int numToGuess = -1;

Console.WriteLine("User 1, enter a number between 0 and 100: ");
try
{
    numToGuess = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Please enter numbers only...");
}

// If number entered is below 0 or above 100 keep asking the Pilot to enter another number
if (Convert.ToInt32(numToGuess) >= 0 && Convert.ToInt32(numToGuess) <= 100)
{
    Console.WriteLine("Number accepted!");
}
else
{
    Console.WriteLine("Please enter a valid number...");
}

// Clear the screen once the Pilot has entered an acceptable number
Console.Clear();

// Ask the second user to guess the number
Console.WriteLine("Player 2, please guess the number. It is between 0 and 100... ");
int numGuessed = Convert.ToInt32(Console.ReadLine());

while (numGuessed != numToGuess)
{
    if (numGuessed < numToGuess)
    {
        Console.WriteLine("Your guess is too low. Try again...");
        numGuessed = Convert.ToInt32(Console.ReadLine());
    }
    else if (numGuessed > numToGuess)
    {
        Console.WriteLine("Your guess is too high. Try again...");
        numGuessed = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine($"Congrats! You guessed the correct number. The number was {numToGuess}");

