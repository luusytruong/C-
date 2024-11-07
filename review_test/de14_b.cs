namespace review_test
{
 class Process14{
    public event EventHandler? OnProcessCompleted;

    public void CompleteProcess(){
        Console.WriteLine($"tien trinh dang duoc hoan thanh ...");
        OnProcessCompleted?.Invoke(this, EventArgs.Empty);
    }
    public static void NotificationOnComplete(object? sender, EventArgs e){
        Console.WriteLine($"tien trinh da duoc hoan thanh");
    }
 }   
}
