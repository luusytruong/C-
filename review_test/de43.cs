namespace review_test;
class Employee43
{
    public void Work() { }
}
class Manager43 : Employee43
{
    public new void Work()
    {
        Console.WriteLine($"quan ly lam viec");
    }
}
class Developer43 : Employee43
{
    public new void Work()
    {
        Console.WriteLine($"lap trinh vien lam viec");
    }
}
//2
class Delegate43
{
    public delegate int MathOperation(int a, int b);
    public int Subtract(int a, int b)
    {
        int c = a - b;
        Console.WriteLine($"phep tru: {a} - {b} = {c}");
        return c;
    }
}