namespace review_test;
class Laptop37
{
    public string? Brand { get; set; }
    public int Price { get; set; }
    public void ShowInfo()
    {
        Console.WriteLine($"Laptop Brand: {Brand}, Price: {Price}");
    }
}
//2
class Delegate37
{
    public delegate int MathOperation(int a, int b);
    public int Multiply(int a, int b)
    {
        int c = a * b;
        Console.WriteLine($"phep nhan: {a} * {b} = {c}");
        return c;
    }
}