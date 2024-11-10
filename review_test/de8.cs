namespace review_test;

abstract class Vehicle8
{
    public abstract void Start();
    public abstract void Stop();
}
class Car8 : Vehicle8
{
    public override void Start()
    {
        Console.WriteLine($"car is moving");
    }
    public override void Stop()
    {
        Console.WriteLine($"car is stop");
    }
}
class Motorbike8 : Vehicle8
{
    public override void Start()
    {
        Console.WriteLine($"motorbike is moving");
    }
    public override void Stop()
    {
        Console.WriteLine($"motobike is stop");
    }
}
//2
class Delegate8
{
    public delegate int CompareHandler(string a, string b);
}

