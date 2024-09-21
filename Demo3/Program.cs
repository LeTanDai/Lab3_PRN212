using System;

class Program
{
    static void Main(string[] args)
    {
        MyCollection<Person> collection = new MyCollection<Person>();
        var p1 = new Person() { FirstName = "Le", LastName = "Tan Dai",Age = 20};
        var p2 = new Person() { FirstName = "Le", LastName = "Tan Vy", Age = 25};
        collection.AddItem(p1,p2);
        foreach(var p in collection)
        {
            Console.WriteLine(p);
        }
        Console.ReadLine();
    }
}
