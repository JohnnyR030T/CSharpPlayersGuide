using System.Net.WebSockets;

Console.WriteLine("Target Row?: ");
int targetRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Target Column?: ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

var westSide = $"({targetRow}, {targetColumn - 1})";
var eastSide = $"({targetRow}, {targetColumn + 1})";
var northSide = $"({targetRow + 1}, {targetColumn})";
var southSide = $"({targetRow - 1}, {targetColumn})";

Console.WriteLine($"West Side: {westSide}");
Console.WriteLine($"North Side: {northSide}");
Console.WriteLine($"East Side: {eastSide}");
Console.WriteLine($"South Side: {southSide}");