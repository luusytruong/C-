namespace review_test;
class Product40
{
    public string? Name { get; set; }
    public int Price { get; set; }
    public void Display()
    {
        Console.WriteLine($"san pham: {Name}, {Price}");
    }
    public Product40(string name, int price)
    {
        Name = name;
        Price = price;
        Display();
    }
}
//2
class Delegate40
{
    public delegate double OperationHandler(double a, double b);
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            return 0;
        }
        return a / b;
    }
}