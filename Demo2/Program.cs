using System;

class Program
{
    static void Main(string[] args)
    {
        SortedSet<int> set = new SortedSet<int>() {1,2,3};
        set.Add(4);
        set.Add(5);
        set.Add(6);
        Console.Write("Elements of mySet:");
        foreach(var i in set)
        {
            Console.Write($"{i,3}");
        }
        Console.ReadLine();
    }
}
