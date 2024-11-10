namespace review_test;
class Account31
{
    private int Balance { get; set; }
    public Account31(int value)
    {
        Balance = value;
    }
    public int Deposit(int value)
    {
        Balance += value;
        Console.WriteLine($"so du sau khi them: {Balance}");
        return Balance;
    }
    public int WithDraw(int value)
    {
        Balance -= value;
        Console.WriteLine($"so du sau khi rut: {Balance}");
        return Balance;
    }
}
//2
class Delegate31
{
    public delegate int CalculationHandler(int a, int b);
    public int Subtract(int a, int b)
    {
        int c = a - b;
        Console.WriteLine($"phep tru: {a} - {b} = {c}");
        return c;
    }
}