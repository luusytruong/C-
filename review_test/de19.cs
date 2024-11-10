namespace review_test;
abstract class Appliance19
{
    public abstract void TurnOn();
}
class Fan19 : Appliance19
{
    public override void TurnOn()
    {
        Console.WriteLine($"quat da duoc bat");
    }
}
class AirConditioner19 : Appliance19
{
    public override void TurnOn()
    {
        Console.WriteLine($"dieu hoa da duoc bat");
    }

}