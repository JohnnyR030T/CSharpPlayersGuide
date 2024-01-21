Console.WriteLine("Please enter a number from the menu below...");
Console.WriteLine("The following items are available: ");
Console.WriteLine(@"
    1 - Rope
    2 - Torches
    3 - Climbing Equipment
    4 - Clean Water
    5 - Machette
    6 - Canoe
    7 - Food Supplies
    8 - Exit
");



string response;
int choice = Convert.ToInt32(Console.ReadLine()); // Replace 1 with the actual value of choice


response = choice switch
{
    1 => "Rope costs 10 gold.",
    2 => "Torches cost 16 gold",
    3 => "Climbing Equipment costs 24 gold",
    4 => "Clean Water costs 2 gold",
    5 => "Machette costs 20 gold",
    6 => "Canoe costs 200 gold",
    7 => "Food Supplies cost 2 gold",
    8 => "Goodbye..."
};

Console.WriteLine(response);





