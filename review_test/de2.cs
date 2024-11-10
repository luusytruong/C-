namespace review_test;

//1a: kh có nội dung = abstract
public abstract class Shape
{
    public abstract void Draw();
}
//1b
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"ve mot hinh tron");
    }
}
//1c
public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"ve mot hinh chu nhat");
    }
}
//2a
public class Task
{
    //tạo event OnCompleted với kiểu delegate là EvnetHandler nhận 2 đối số (object? sender, EnventArgs e)
    public event EventHandler? OnCompleted;
    //2c tạo pt CompleteTask() để kh event OnCompleted
    public void CompleteTask()
    {
        Console.WriteLine($"tac vu dang bat dau ...");
        //kích hoạt event, dt gửi chính là pt gọi event(this) và 1 sự kiện rỗng
        OnCompleted?.Invoke(this, EventArgs.Empty);
    }

    //2c đăng ký pt xly event
    public static void TaskCompletedHandler(object? sender, EventArgs e)
    {
        Console.WriteLine($"tac vu da hoan thanh !");
    }
}

