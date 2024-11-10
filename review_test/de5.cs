namespace review_test;

interface IMovable
{
    void Move();
}
class Car5 : IMovable
{
    public void Move()
    {
        Console.WriteLine($"xe oto dang di chuyen");
    }
}
class Bike5 : IMovable
{
    public void Move()
    {
        Console.WriteLine($"xe dap dang di chuyen");
    }
}
