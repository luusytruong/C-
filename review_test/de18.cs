namespace review_test;
interface IDrive18
{
    void Drive();
}
class Car18 : IDrive18
{
    public void Drive()
    {
        Console.WriteLine($"dang lai xe o to");
    }
}
class Truck18 : IDrive18
{
    public void Drive()
    {
        Console.WriteLine($"dang lai xe tai");
    }
}
