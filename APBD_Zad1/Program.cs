// See https://aka.ms/new-console-template for more information
Console.WriteLine("Podaj imie:");
string input = Console.ReadLine();
Console.WriteLine("Czesc "+input);
Console.WriteLine("Podaj liczby:");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Sum = "+(a+b));
Console.WriteLine("Subtract = "+(a-b));
Console.WriteLine("2. "+(b-a));
