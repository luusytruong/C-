namespace review_test;
//de21_1
interface IMovable21
{
    void Move();
}
interface IFlyable21 : IMovable21
{
    void Fly();
}
class Helicopter21 : IFlyable21
{
    public void Move()
    {
        Console.WriteLine($"truc thang di chuyen");
    }
    public void Fly()
    {
        Console.WriteLine($"truc thang bay");
    }
}
//de21_2
class Event21{
    public event EventHandler? OnMessageReceived;

    public void ReceiveMessage(){
        Console.WriteLine($"tin nhan dang den ...");
        OnMessageReceived?.Invoke(this, EventArgs.Empty);
    }
    public static void NotificationOnReceived(object? sender, EventArgs e){
        Console.WriteLine($"da nhan tin nhan !");
    }
}