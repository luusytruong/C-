namespace review_test;
interface IPlayable36
{
    void Play();
}
class Game36 : IPlayable36
{
    public void Play()
    {
        Console.WriteLine($"choi game");
    }
}
class Music36 : IPlayable36
{
    public void Play()
    {
        Console.WriteLine($"nghe nhac");
    }
}
//2
class Phone36
{
    public event Action? OnCallReceived;
    public void ReceivedCall()
    {
        OnCallReceived?.Invoke();
    }
}