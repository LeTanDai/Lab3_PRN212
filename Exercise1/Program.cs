 using System;

class Program
{
    static void Main(string[] args)
    {
        Calculate<int> intCalculator = new Calculate<int>();
        Console.WriteLine("Addition: " + intCalculator.Add(5, 3));
        Console.WriteLine("Subtraction: " + intCalculator.Subtract(10, 4));
        Console.WriteLine("Multiplication: " + intCalculator.Multiply(6, 2));
        Console.WriteLine("Division: " + intCalculator.Divide(8, 2));


        Calculate<double> doubleCalculator = new Calculate<double>();
        Console.WriteLine("Addition: " + doubleCalculator.Add(4.5, 2.3));
        Console.WriteLine("Subtraction: " + doubleCalculator.Subtract(7.8, 3.2));
        Console.WriteLine("Multiplication: " + doubleCalculator.Multiply(3.5, 1.5));
        Console.WriteLine("Division: " + doubleCalculator.Divide(10.0, 2.5));
    }
}
