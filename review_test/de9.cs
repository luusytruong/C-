namespace review_test;

class Animal2
{
    public virtual void MakeSound()
    {
        Console.WriteLine($"rau rau rau");
    }
}
class Dog2 : Animal2
{
    public override void MakeSound()
    {
        Console.WriteLine($"gau gau");
    }
}
class Cat : Animal2
{
    public override void MakeSound()
    {
        Console.WriteLine($"meo meo");
    }
}
//2
class OnDataReceivedClass
{
    public event EventHandler? OnDataReceived;
    public void BatDauEvent()
    {
        Console.WriteLine($"Event đang được bắt đầu ...");
        OnDataReceived?.Invoke(this, EventArgs.Empty);
    }
    public static void HoanThanhEvent(object? sender, EventArgs e)
    {
        Console.WriteLine($"Event đã được hoàn thành !");
    }
    public static void HoanThanhEvent2(object? sender, EventArgs e)
    {
        Console.WriteLine($"Event đã được hoàn thành 2 !");
    }
    public static void HoanThanhEvent3(object? sender, EventArgs e)
    {
        Console.WriteLine($"Event đã được hoàn thành 3 !");
    }
}
