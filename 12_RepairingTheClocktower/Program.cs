
Console.Title = "Repairing The Clocktower";

Console.WriteLine("Enter a number: ");
int theNumber = Convert.ToInt32(Console.ReadLine());

if (theNumber % 2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}