namespace review_test;
interface IDriveable39
{
    void Drive();
}
class Car39 : IDriveable39
{
    public void Drive()
    {
        Console.WriteLine($"lai oto");
    }
}
class Bike39 : IDriveable39
{
    public void Drive()
    {
        Console.WriteLine($"lai xe dap");
    }
}
//2
class Delegate39
{
    public delegate int CaculationHandler(int a, int b);
    public int Multiply(int a, int b)
    {
        int c = a * b;
        Console.WriteLine($"phep nhan: {a} * {b} = {c}");
        return c;
    }
}