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
double[] tab = new double[] { a, b };
Console.WriteLine("Sum = "+(a+b));
Console.WriteLine("Subtract = "+(a-b));
Console.WriteLine("2. "+(b-a));
Console.WriteLine("Multiply = "+(a * b));
Console.WriteLine("Divide = "+(a / b));
Console.WriteLine("Merhods:");
Console.WriteLine("Avarage: "+ StatisticsHelper.CalculateAverage(tab));
Console.WriteLine("Max: "+ StatisticsHelper.CalculateMax(tab));
Console.WriteLine("Min: "+ StatisticsHelper.CalculateMin(tab));

//comentaz
// bardzo wazny komentarz bez którego się nieobejdzie
public static class StatisticsHelper
{
    public static double CalculateAverage(double[] values)
    {
        if (values == null || values.Length == 0)
            return 0;

        return values.Average();
    }
    public static double CalculateMax(double[] values)
    {
        if (values == null || values.Length == 0)
            return 0;
        return values.Max();
    }
    public static double CalculateMin(double[] values)
    {
        if (values == null || values.Length == 0)
            return 0;
        return values.Min();
    }
}
