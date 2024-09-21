using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList personList = new ArrayList();
        personList.Add(new Product("LV Shoes",100000,2));
        personList.Add(new Product("Sweater", 150000, 3));
        personList.Add(new Product("Hoodie",50000, 10));
        personList.Add(new Product("Bag",20000, 5));
        personList.Add(new Product("Flower", 100000, 2));
        foreach(Product p in personList)
        {
            Console.WriteLine(p);
        }
    }
}
