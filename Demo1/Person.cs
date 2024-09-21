using System;

class Person
{
    public int Age { get; set; }
    public string FirstName {  get; set; }
    public string LastName { get; set; }
    public override string ToString() =>
        $"Name: {FirstName} {LastName}, Age: {Age}";
}
