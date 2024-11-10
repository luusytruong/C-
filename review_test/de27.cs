namespace review_test;
class Animal27
{
    public string? Name { get; set; }
    public Animal27(string name)
    {
        Name = name;
    }
}
class Dog27 : Animal27
{
    public string? Breed { get; set; }
    public Dog27(string name, string breed) : base(name)
    {
        Breed = breed;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Breed: {Breed}");
    }
}
class Task27
{
    public event EventHandler? OnFinished;
    public void CompletedTask()
    {
        Console.WriteLine($"dang duoc hoan thanh ...");
        OnFinished?.Invoke(this, EventArgs.Empty);
    }
    public static void NotificationOnFinished(object? sender, EventArgs e)
    {
        Console.WriteLine($"da hoan thanh !");
    }
}