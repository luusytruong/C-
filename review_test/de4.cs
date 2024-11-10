namespace review_test;

//a
class Employee
{
    public string? Name { get; set; }
    public string? Position { get; set; }
}
//b
class Manager : Employee
{
    public string? Department { get; set; }
}
//c
class Developer : Employee
{
    public string? ProgrammingLanguage { get; set; }
}
//2
class CalculationHandlerDelegate
{
    public delegate int CalculationHandler(int a, int b);
    public int Multiply(int a, int b)
    {
        int result = a * b;
        Console.WriteLine($"phep nhan {a} va {b}: {result}");
        OnCalculationComplete?.Invoke(this, EventArgs.Empty);
        return result;
    }
    public event EventHandler? OnCalculationComplete;
    public static void OnCompleted(object? sender, EventArgs e)
    {
        Console.WriteLine($"phep nhan da hoan thanh");
    }
}

