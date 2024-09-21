using System;

class Program
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
    public static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        Console.WriteLine($"Before swap: a = {a}; b = {b}");
        Swap<int>(ref a, ref b);                       
        Console.WriteLine($"After swap: a = {a}; b = {b}");
        Console.WriteLine();
        string a1 = "A";
        string b1 = "B";
        Console.WriteLine($"Before swap: a1 = {a1}; b1 = {b1}");
        Swap<string>(ref a1, ref b1);
        Console.WriteLine($"After swap: a1 = {a1}; b1 = {b1}");
    }
}