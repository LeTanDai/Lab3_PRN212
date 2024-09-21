using System;

class Program
{
    static void Main(string[] args)
    {
        List<Person> person = new List<Person>()
        {
            new Person{FirstName = "Le", LastName = "Tan Dai", Age = 20},
            new Person{FirstName = "Le", LastName = "Tan Vy", Age = 25},
            new Person{FirstName = "Ngo", LastName = "Ba Kha", Age = 30},
            new Person{FirstName = "Le", LastName = "Nhung Nho", Age = 20}
        };
        Console.WriteLine("Items in list: {0}",person.Count);
        foreach(Person p in person)
        {
            Console.WriteLine(p);
        }
    }
}
