namespace review_test
{
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
}
