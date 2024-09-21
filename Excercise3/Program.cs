using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Hashtable daysOfWeek = new Hashtable();

        daysOfWeek.Add(1, "Monday");
        daysOfWeek.Add(2, "Tuesday");
        daysOfWeek.Add(3, "Wednesday");
        daysOfWeek.Add(4, "Thursday");
        daysOfWeek.Add(5, "Friday");
        daysOfWeek.Add(6, "Saturday");
        daysOfWeek.Add(7, "Sunday");

        if (daysOfWeek.ContainsValue("Tuesday"))
        {
            Console.WriteLine("Tuesday is found in the Hashtable.");
        }
        else
        {
            Console.WriteLine("Tuesday is not found in the Hashtable.");
        }

        int[] keys = new int[daysOfWeek.Count];
        daysOfWeek.Keys.CopyTo(keys, 0);
        Array.Sort(keys);

        foreach (int key in keys)
        {
            Console.WriteLine($"Key: {key}, Value: {daysOfWeek[key]}");
        }
    }
}