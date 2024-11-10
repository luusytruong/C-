namespace review_test;
interface IPlayable45
{
    void Play();
}
class Game45 : IPlayable45
{
    public void Play()
    {
        Console.WriteLine($"choi game");
    }
}
class Music45 : IPlayable45
{
    public void Play()
    {
        Console.WriteLine($"nghe nhac");
    }
}
//2
class Delegate45
{
    public delegate int MathOperation(int a, int b);
    public int Add(int a, int b)
    {
        int c = a + b;
        Console.WriteLine($"phep cong: {a} + {b} = {c}");
        return c;
    }
}