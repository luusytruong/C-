namespace review_test;
class Product33
{
    public string? Name { get; set; }
    public int Price { get; set; }
    public void DisplayInfo()
    {
        Console.WriteLine($"Product: {Name}, {Price}");
    }
    public Product33(string name, int price)
    {
        Name = name;
        Price = price;
        DisplayInfo();
    }
}
//2
class Alram33
{
    public event EventHandler? OnAlarmRang;
    public void RingAlarm()
    {
        Console.WriteLine($"chuong dang rung ...");
        OnAlarmRang?.Invoke(this, EventArgs.Empty);
    }
    public static void NotificationOnRingAlarm(object? sender, EventArgs e)
    {
        Console.WriteLine($"chuong da duoc rung");
    }
}

