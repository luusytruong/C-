namespace review_test;
class Shape30
{
    public void Draw() { }
}
class Circle30 : Shape30
{
    public new void Draw()
    {
        Console.WriteLine($"ve hinh tron");
    }
}
//2
class Process30
{
    public event EventHandler? OnProcessCompleted;
    public void FinishProcess()
    {
        Console.WriteLine($"dang hoan thanh tien trinh ...");
        OnProcessCompleted?.Invoke(this, EventArgs.Empty);
    }
    public static void NotificationOnFinishedProcess(object? sender, EventArgs e)
    {
        Console.WriteLine($"da hoan thanh tien trinh");

    }
}