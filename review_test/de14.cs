namespace review_test;

class BaseClass14
{
    public virtual void Display() { }
}
class DerivedClass14 : BaseClass14
{
    public override void Display()
    {
        Console.WriteLine($"day la hien thi tu lop con");
    }
}
//2
class Process14
{
    public event EventHandler? OnProcessCompleted;

    public void CompleteProcess()
    {
        Console.WriteLine($"tien trinh dang duoc hoan thanh ...");
        OnProcessCompleted?.Invoke(this, EventArgs.Empty);
    }
    public static void NotificationOnComplete(object? sender, EventArgs e)
    {
        Console.WriteLine($"tien trinh da duoc hoan thanh");
    }
}
