namespace review_test;

class Person28
{
    public string? Name { get; set; }
    public int Age { get; set; }

    // private string? name;
    // private int age;

    // public string Name
    // {
    //     get { return name; }
    //     set { name = value; }
    // }
    // public int Age
    // {
    //     get { return age; }
    //     set { age = value; }
    // }
    public Person28(string name, int age)
    {
        Name = name;
        Age = age;
        DisplayInfo();
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
//2
class Sensor28
{
    public event EventHandler? OnSensorTriggered;
    public void TriggeredSensor()
    {
        Console.WriteLine($"dang kich hoat cam bien ...");
        OnSensorTriggered?.Invoke(this, EventArgs.Empty);
    }
    public static void NotificationOnTrigeerdSensor(object? sender, EventArgs e)
    {
        Console.WriteLine($"cam bien da duoc kich hoat !");
    }
}