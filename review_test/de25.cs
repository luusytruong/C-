namespace review_test;
class Car25
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public Car25(string make, string model)
    {
        Make = make;
        Model = model;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Make: {Make}, Model: {Model}");
    }
}
class Delegate25
{
    public delegate int MathOperation(int a, int b);
    public int Add(int a, int b)
    {
        int c = a + b;
        Console.WriteLine($"result {a} + {b} = {c}");
        return c;
    }
}