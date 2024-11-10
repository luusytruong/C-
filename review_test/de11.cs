namespace review_test;

interface IDrawable11
{
    void Draw();
}
class Shape11 : IDrawable11
{
    public virtual void Draw()
    {
        Console.WriteLine($"ve mot hinh");
    }
}
class Circle11 : Shape11
{
    public override void Draw()
    {
        Console.WriteLine($"ve mot hinh tron");
    }
}
