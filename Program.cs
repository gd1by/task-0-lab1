using System;

class Program
{
    static Random random = new Random();

    static double SquareDifference(double a, double b)
    {
        return Math.Pow(a - b, 2);
    }

    static void Main(string[] args)
    {
        double num1 = random.NextDouble() * 10; // Генерируем случайное число от 0 до 10.
        double num2 = random.NextDouble() * 10; // Генерируем второе случайное число от 0 до 10.

        double result = SquareDifference(num1, num2);

        Console.WriteLine($"Первое случайное число: {num1}");
        Console.WriteLine($"Второе случайное число: {num2}");
        Console.WriteLine($"Квадрат разности равен: {result}");
    }
}
