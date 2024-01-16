

int estate = 0;
int duchy = 0;
int province = 0;

Console.WriteLine("How many estates did you buy?");
int.TryParse(Console.ReadLine(), out estate);

Console.WriteLine("How many duchies did you buy?");
int.TryParse(Console.ReadLine(), out duchy);

Console.WriteLine("How many provinces did you buy?");
int.TryParse(Console.ReadLine(), out province);

// Calculate the total victory points.
int totalVictoryPoints = estate * 1 + duchy * 3 + province * 6;

// Add the points from the estates, duchies and provinces together and print the result.
Console.WriteLine($"You have {totalVictoryPoints} victory points.");
