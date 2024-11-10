namespace review_test;
abstract class Instrument24
{
    public abstract void Play();
}
class Guitar24 : Instrument24
{
    public override void Play()
    {
        Console.WriteLine($"choi dan guitar");
    }
}
class Piano24 : Instrument24
{
    public override void Play()
    {
        Console.WriteLine($"choi dan piano");
    }
}
class Delegate24
{
    public delegate void NotificationHandler();

    public void EmailNotification()
    {
        Console.WriteLine($"thong bao tu email");
    }
    public void SMSNotification()
    {
        Console.WriteLine($"thong bao tu sms");
    }
}
