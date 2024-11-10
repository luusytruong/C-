namespace review_test;

class Engine
{
    public void StartEngine()
    {
        Console.WriteLine($"Engine started");
    }
}
class Car
{
    public Engine? Engine { get; set; }
    public Car()
    {
        Engine = new Engine();
    }
    public void StartCar()
    {
        Engine?.StartEngine();
        Console.WriteLine($"Car is now running");
    }
}
