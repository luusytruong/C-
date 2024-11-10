namespace review_test;
class Caculator41
{
    public int Add(int a, int b)
    {
        int c = a + b;
        Console.WriteLine($"int: {a} + {b} = {c}");
        return c;
    }
    public double Add(double a, double b)
    {
        double c = a + b;
        Console.WriteLine($"double: {a} + {b} = {c}");
        return c;
    }
}
//2
class Delegate41
{
    public delegate double CaculatorHandler(double a, double b);
    public double Multiply(double a, double b)
    {
        double c = a * b;
        Console.WriteLine($"phep nhan: {a} * {b} = {c}");
        return c;
    }
}