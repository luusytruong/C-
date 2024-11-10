namespace review_test;
class Student29
{
    public string? Name { get; set; }
    public Student29(string name)
    {
        Name = name;
        DisplayInfo();
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Student: {Name}");
    }
}
//2
class Delegate29
{
    public delegate int Operation(int a, int b);
    public int Multiply(int a, int b)
    {
        int c = a * b;
        Console.WriteLine($"ket qua cua phep nhan: {a} * {b} = {c}");
        return c;
    }
}