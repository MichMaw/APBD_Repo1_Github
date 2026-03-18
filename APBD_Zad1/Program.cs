// See https://aka.ms/new-console-template for more information
Console.WriteLine("Podaj imie:");
string input = Console.ReadLine();
Console.WriteLine("Czesc "+input);
Console.WriteLine("Podaj liczby:");
double a, b;
while (!double.TryParse(Console.ReadLine(), out a))
{
    Console.Write("Invalid input. Try again: ");
}

while (!double.TryParse(Console.ReadLine(), out b))
{
    Console.Write("Invalid input. Try again: ");
}
Console.WriteLine("Sum = "+(a+b));
Console.WriteLine("Subtract = "+(a-b));
Console.WriteLine("2. "+(b-a));
Console.WriteLine("Multiply = "+(a * b));
Console.WriteLine("Divide = "+(a / b));


public static class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0)
            return 0;

        return values.Average();
    }
}