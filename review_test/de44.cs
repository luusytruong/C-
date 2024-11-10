namespace review_test;
class Animal44
{
    public string? Name { get; set; }
    public Animal44(string n)
    {
        Name = n;
    }
}
class Cat44 : Animal44
{
    public string? Color { get; set; }
    public Cat44(string n, string c) : base(n)
    {
        Color = c;
        Console.WriteLine($"Meo ten: {Name}, mau {Color}");
    }
}
//2
class Delegate44
{
    public delegate int OperationHandler(int a, int b);
    public int Multiply(int a, int b)
    {
        int c = a * b;
        Console.WriteLine($"phep nhan: {a} x {b} = {c}");
        return c;
    }
}