namespace review_test;
interface IDriveable32
{
    void Drive();
}
class Car32 : IDriveable32
{
    public void Drive()
    {
        Console.WriteLine($"lai o to");
    }
}
class Bike32 : IDriveable32
{
    public void Drive()
    {
        Console.WriteLine($"lai xe dap");
    }
}
//2
class Delegate32
{
    public delegate int MathOperation(int a, int b);
}