namespace review_test;

//tạo lớp animal
public class Animal
{
    //thuộc tính tên
    public string? Name { get; set; }
    //tuổi
    public int Age { get; set; }
    //phương thức ảo hoá DisplayInfor (virtual)
    public virtual void DisplayInfor()
    {
        Console.WriteLine($"name: {Name}, age: {Age}");
    }
}
//Dog kế thừa từ Animal sử dụng ':'
public class Dog : Animal
{
    //thêm tt Breed (loài)
    public string? Breed { get; set; }
    //ghi đè phương thức DisplayInfor sử dụng override
    //(lưu ý lớp bị ghi đè phải là virtual)
    public override void DisplayInfor()
    {
        Console.WriteLine($"name: {Name}, age: {Age}, breed: {Breed}");
    }
}
//create class
public class OperationDelegate
{
    //2a create delegate
    public delegate int Operation(int a, int b);
    //2b create func add
    public int Add(int a, int b)
    {
        return a + b;
    }
}

