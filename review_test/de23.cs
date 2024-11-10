namespace review_test;
class Person23
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public Person23(string name)
    {
        Name = name;
        Age = 0;
        DisplayInfo();
    }
    public Person23(string name, int age)
    {
        Name = name;
        Age = age;
        DisplayInfo();
    }
    void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

}
class Event23{
    public event EventHandler? OnGameOver;
    public void EndGame(){
        Console.WriteLine($"dang ket thuc tro choi ...");
        OnGameOver?.Invoke(this, EventArgs.Empty);
    }
    public static void NotificationOnGameOver(object? sender, EventArgs e){
        Console.WriteLine($"tro choi da ket thuc !");
    }
}