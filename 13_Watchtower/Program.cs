Console.WriteLine("Enter a positive or negative number for x value: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a positive or negative number for y value: ");
int y = Convert.ToInt32(Console.ReadLine());


if (x == 0 && y == 0)
{
    Console.WriteLine("The enemy is here!");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("The enemy is in the North West!");
}
else if (x == 0 && y > 0)
{
    Console.WriteLine("The enemy is in the North!");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("The enemy is in the North East!");
}
else if (x > 0 && y == 0)
{
    Console.WriteLine("The enemy is in the East!");
}
else if (y == 0 && x < 0){
    Console.WriteLine("The enemy is in the West!");
}
else if(y == 0 && x > 0){
    Console.WriteLine("The enemy is in the East!");
}
else if (y < 0 && x < 0)
{
    Console.WriteLine("The enemy is in the South West!");
}
else if (y < 0 && x == 0)
{
    Console.WriteLine("The enemy is in the South!");
}
else if (y < 0 && x > 0)
{
    Console.WriteLine("The enemy is in the South East!");
}
else
{
    Console.WriteLine("The enemy is not here!");
}