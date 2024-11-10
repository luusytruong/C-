namespace review_test;
class Caculator34
{
    public int Add(int a, int b)
    {
        int c = a + b;
        Console.WriteLine($"int: {a}+{b}={c}");
        return c;
    }
    public double Add(double a, double b)
    {
        double c = a + b;
        Console.WriteLine($"double: {a}+{b}={c}");
        return c;
    }
}
class GameLevel34
{
    public event EventHandler? OnLevelCompleted;
    public void CompleteLevel()
    {
        Console.WriteLine($"dang hoan thanh cap do ...");
        OnLevelCompleted?.Invoke(this, EventArgs.Empty);
    }
    public static void NotificationOnLevelCompleted(object? sender, EventArgs e)
    {
        Console.WriteLine($"da hoan thanh cap do !");
    }
}
class GameLevel34_2
{
    public event Action? OnLevelCompleted;
    public void CompleteLevel(){
        OnLevelCompleted?.Invoke();
    }
}