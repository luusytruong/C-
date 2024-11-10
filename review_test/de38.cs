namespace review_test;
interface IRunnable38
{
    void Run();
}
class Animal38 : IRunnable38
{
    public void Run()
    {
        Console.WriteLine($"dong vat chay");
    }
}
class Car38 : IRunnable38
{
    public void Run()
    {
        Console.WriteLine($"oto chay");
    }
}
//2
class EmailSender38
{
    public event Action? OnEmailSent;
    public void SendEmail()
    {
        OnEmailSent?.Invoke();
    }
}