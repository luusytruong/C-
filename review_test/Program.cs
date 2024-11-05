﻿namespace review_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //de1 1
            {
                //khởi tạo dt dog từ lớp Dog
                Dog dog = new Dog();
                //đặt thuộc tính bằng dog.key = value (key là tt, pt trong lớp animal và dog)
                dog.Name = "ngoc";
                dog.Age = 10;
                dog.Breed = "rau";
                dog.DisplayInfor();
                //đầu ra "name: ngoc, age: 10, breed: rau"

                //de1 2
                //khởi tạo đối tượng của lớp OperationDelegate
                OperationDelegate opd = new OperationDelegate();
                //2c sử dụng dlg để tham chiếu đến pt Add()
                OperationDelegate.Operation op = new OperationDelegate.Operation(opd.Add);
                //2d sử dụng dlg để tính tổng 2 số
                Console.WriteLine($"Sum 2 numbers: {op(10, 1)}");
                //đầu ra "Sum 2 numbers: 11"
            }

            //de2 
            {
                //2d sd tính đa hình để tạo ds các dt Shape và gọi pt Draw()
                List<Shape> shapes = new List<Shape>{
                //tao dt hinh tron
                new Circle(),
                //tao dt hinh vuong
                new Rectangle()
                };
                //vòng lặp tạo 1 đối tượng là shape có kiểu Shape nằm trong shapes 
                foreach (Shape shape in shapes)
                {
                    //gọi pt Draw() cho từng dt trong list
                    shape.Draw();
                }
                //đầu ra "ve mot hinh tron, ve mot hinh chu nhat"

                //de2_b
                //2d tạo dt của task và khoat event OnCompleted
                Task task = new Task();
                //đăng ký pt xly event
                task.OnCompleted += Task.TaskCompletedHandler;
                //kích hoạt event OnCompleted
                task.CompleteTask();
            }
            //de3
            {
                //3a
                Account account = new Account();
                Console.WriteLine($"tien cua tai khoan la: {account.Init(2)}");
                Console.WriteLine($"tien cua tai khoan sau khi them: {account.Deposit(100)}");
                Console.WriteLine($"tien cua tai khoan sau khi rut: {account.WithDraw(10)}");
                //3b
                MathOperationDelegate mod = new MathOperationDelegate();
                MathOperationDelegate.MathOperation sub = new MathOperationDelegate.MathOperation(mod.Subtract);
                Console.WriteLine($"phep tru 2 so: {sub(10, 1)}");
                
            }
        }
    }
}