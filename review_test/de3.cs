namespace review_test;

class Account
{
    private int Balance { get; set; }
    public int Init(int value)
    {
        //toán tử 3 ngôi để kiểm tra value
        Balance = value != 0 ? value : 0;
        return Balance;
    }
    public int Deposit(int value)
    {
        Balance += value;
        return Balance;
    }
    public int WithDraw(int value)
    {
        Balance -= value;
        return Balance;
    }
}
//2
class MathOperationDelegate
{
    public delegate int MathOperation(int a, int b);
    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

