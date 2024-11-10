namespace review_test;
class Book42
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public Book42(string t, string a)
    {
        Title = t;
        Author = a;
        Console.WriteLine($"Book: ten {Title}, tac gia {Author}");
    }
}
//2
class Delegate42
{
    public delegate int OperationHandler(int a, int b);
    public int Add(int a, int b)
    {
        int c = a + b;
        Console.WriteLine($"phep cong: {a} + {b} = {c}");
        return c;
    }
}