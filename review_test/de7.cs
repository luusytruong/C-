namespace review_test;

class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public Person()
    {
        Name = "Name";
        Age = 0;
    }
    public Person(string? name, int age)
    {
        Name = name;
        Age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
//2
class MODelegate
{
    public delegate double MathOperation(int a, int b);
    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            return 0;
        }
        return a / b;
    }
}

