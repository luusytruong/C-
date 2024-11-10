namespace review_test;
//1
class BankAccount22
{
    private int Balance { get; set; }
    public BankAccount22(int value)
    {
        if (value < 0)
        {
            // throw new ArgumentException("so tien khong the am");
            Console.WriteLine($"tien khong the la so am, mac dinh = 0");
            value = 0;

        }
        Balance = value;
    }
    public int Deposit(int value)
    {
        Console.WriteLine();
        Console.WriteLine($"ban vua them {value} vao tai khoan");
        Balance += value;
        Console.WriteLine($"so du: {Balance}");
        Console.WriteLine();
        return Balance;
    }
    public int WithDraw(int value)
    {
        Console.WriteLine();
        Console.WriteLine($"ban vua rut {value} khoi tai khoan");
        Balance -= value;
        Console.WriteLine($"so du: {Balance}");
        Console.WriteLine();
        return Balance;
    }
}
//2
class Event22
{
    public event EventHandler? OnTemperatureChanged;
    public void UpdateTemperature()
    {
        Console.WriteLine($"cap nhat nhiet do ...");
        OnTemperatureChanged?.Invoke(this, EventArgs.Empty);
    }
    public static void NotificationUpdateTemperature(object? sender, EventArgs e)
    {
        Console.WriteLine($"cap nhat nhiet do thanh cong !");
    }
}