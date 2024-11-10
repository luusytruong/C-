namespace review_test;

class Bird12
{
    public virtual void Fly12()
    {
        Console.WriteLine($"Bird cant fly");
    }
}
class Eagle12 : Bird12
{
    public override void Fly12()
    {
        Console.WriteLine($"Eagle can fly");
    }
}
class Penguin12 : Bird12
{
    public override void Fly12()
    {
        Console.WriteLine($"Penguin can't fly");
    }
}
//2
class Delegate12
{
    public delegate void NotificationHandler();
}
class Notification12
{
    public void EmailNotification()
    {
        Console.WriteLine($"day la mot thong bao tu email");
    }
    public void SmsNotification()
    {
        Console.WriteLine($"day la mot thong bao tu sms");
    }
}