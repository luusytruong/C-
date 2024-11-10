namespace review_test;

interface IDriveable
{
    void Drive();
}
interface IFlyable
{
    void Fly();
}
class CarPlane : IDriveable, IFlyable
{
    public void Drive()
    {
        Console.WriteLine($"Car running");
    }
    public void Fly()
    {
        Console.WriteLine($"Plane is flying");
    }

}