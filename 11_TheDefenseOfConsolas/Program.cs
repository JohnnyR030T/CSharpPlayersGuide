
// Display a title
Console.Title = "Defense of Consolas";


Console.WriteLine("Target Row?: ");
int targetRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Target Column?: ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

// Set deployment location logic
var westSide = $"({targetRow}, {targetColumn - 1})";
var eastSide = $"({targetRow}, {targetColumn + 1})";
var northSide = $"({targetRow + 1}, {targetColumn})";
var southSide = $"({targetRow - 1}, {targetColumn})";


// Display the results
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"West Side: {westSide}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"North Side: {northSide}");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"East Side: {eastSide}");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"South Side: {southSide}");

// Play a sound
Console.Beep();