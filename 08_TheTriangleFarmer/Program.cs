Console.WriteLine("Enter base of the triangle:");
int baseInput = int.Parse(Console.ReadLine());

Console.WriteLine("Enter height of the triangle:");
int heightInput = int.Parse(Console.ReadLine());

double area = (baseInput * heightInput) / 2.0;

Console.WriteLine($"The area of the triangle is: {area}");
