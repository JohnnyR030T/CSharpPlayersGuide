// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a number...");
string userInput = Console.ReadLine();

int number;
if (int.TryParse(userInput, out number))
{
    if (number == 10)
    {
        Console.WriteLine("Hello, World!");
    }
    else
    {
        Console.WriteLine("something besides \"Hello, World!\"");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}


