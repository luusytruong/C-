namespace review_test;

class Counter
{
    public static int Count = 0;
    public static int Increment()
    {
        return Count++;
    }
}
//2
class CalculationHandlerAdd
{
    public delegate int CalculationHandler(int a, int b);
    public int Add(int a, int b)
    {
        Console.WriteLine($"phep cong {a} va {b}: {a + b}");
        return a + b;
    }

}