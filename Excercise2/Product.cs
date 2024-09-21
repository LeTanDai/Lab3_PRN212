using System;

public class Product
{
    public string Name { get; set; }
    public double Cost {  get; set; }
    public int Quantity {  get; set; }

    public Product(string name,double cost,int quantity)
    {
        Name = name;
        Cost = cost;
        Quantity = quantity;
    }
    public override string ToString()
    {
        return $"ProductName: {Name}, Cost: {Cost}, Quantity: {Quantity}";
    }
}
