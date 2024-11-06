namespace review_test
{
    //viết ra file khác tương tự viết ở trên này
    internal class Program
    {
        //đi thi viết ở đây
        static void Main(string[] args)
        {

            // //de1 1
            // {
            //     //khởi tạo dt dog từ lớp Dog
            //     Dog dog = new Dog();
            //     //đặt thuộc tính bằng dog.key = value (key là tt, pt trong lớp animal và dog)
            //     dog.Name = "ngoc";
            //     dog.Age = 10;
            //     dog.Breed = "rau";
            //     dog.DisplayInfor();
            //     //đầu ra "name: ngoc, age: 10, breed: rau"

            //     //de1 2
            //     //khởi tạo đối tượng của lớp OperationDelegate
            //     OperationDelegate opd = new OperationDelegate();
            //     //2c sử dụng dlg để tham chiếu đến pt Add()
            //     OperationDelegate.Operation op = new OperationDelegate.Operation(opd.Add);
            //     //2d sử dụng dlg để tính tổng 2 số
            //     Console.WriteLine($"Sum 2 numbers: {op(10, 1)}");
            //     //đầu ra "Sum 2 numbers: 11"
            // }

            // //de2 
            // {
            //     //2d sd tính đa hình để tạo ds các dt Shape và gọi pt Draw()
            //     List<Shape> shapes = new List<Shape>{
            //     //tao dt hinh tron
            //     new Circle(),
            //     //tao dt hinh vuong
            //     new Rectangle()
            //     };
            //     //vòng lặp tạo 1 đối tượng là shape có kiểu Shape nằm trong shapes 
            //     foreach (Shape shape in shapes)
            //     {
            //         //gọi pt Draw() cho từng dt trong list
            //         shape.Draw();
            //     }
            //     //đầu ra "ve mot hinh tron, ve mot hinh chu nhat"

            //     //de2_b
            //     //2d tạo dt của task và khoat event OnCompleted
            //     Task task = new Task();
            //     //đăng ký pt xly event
            //     task.OnCompleted += Task.TaskCompletedHandler;
            //     //kích hoạt event OnCompleted
            //     task.CompleteTask();
            // }

            // //de3
            // {
            //     //3a
            //     Account account = new Account();
            //     Console.WriteLine($"tien cua tai khoan la: {account.Init(2)}");
            //     Console.WriteLine($"tien cua tai khoan sau khi them: {account.Deposit(100)}");
            //     Console.WriteLine($"tien cua tai khoan sau khi rut: {account.WithDraw(10)}");
            //     //3b
            //     MathOperationDelegate mod = new MathOperationDelegate();
            //     MathOperationDelegate.MathOperation sub = new MathOperationDelegate.MathOperation(mod.Subtract);
            //     Console.WriteLine($"phep tru 2 so: {sub(10, 1)}");
            // }

            // //de4
            // {
            //     //4d
            //     Manager manager = new Manager();
            //     Console.WriteLine($"Manager: Name: {manager.Name = "Ngọc râu"}, Position: {manager.Position = "quản lý"}, Department: {manager.Department = "p quản lý"}");
            //     Developer developer = new Developer();
            //     Console.WriteLine($"Developer: Name: {developer.Name = "Ngọc râu 2"}, Position: {developer.Position = "lập trình viên"}, Department: {developer.ProgrammingLanguage = "ngôn ngữ C#"}");

            //     //4_b
            //     CalculationHandlerDelegate chd = new CalculationHandlerDelegate();
            //     CalculationHandlerDelegate.CalculationHandler mul = new CalculationHandlerDelegate.CalculationHandler(chd.Multiply);
            //     chd.OnCalculationComplete += CalculationHandlerDelegate.OnCompleted;
            //     mul(2,8);
            // }

            // //de7
            // {
            //     //de7_1
            //     Person person1 = new Person();
            //     person1.DisplayInfo();
            //     Person person2 = new Person("Ngoc rau", 10);
            //     person2.DisplayInfo();
            //     //de7_2
            //     MODelegate modd = new MODelegate();
            //     MODelegate.MathOperation divide = new MODelegate.MathOperation(modd.Divide);
            //     Console.WriteLine($"phep chia 10 va 2: {divide(10, 2)}");

            // }

            // //de10
            // {
            //     //de10_1
            //     Counter counter = new Counter();
            //     Counter counter1 = new Counter();

            //     Counter.Increment();
            //     Counter.Increment();

            //     Console.WriteLine($"so lan goi pt: {Counter.Count}");

            //     //de10_2
            //     CalculationHandlerAdd cha = new CalculationHandlerAdd();
            //     CalculationHandlerAdd.CalculationHandler sum = cha.Add;
            //     sum(10, 99);
            // }

            // //de9
            // {
            //     //de9_1
            //     List<Animal2> animal2s = new List<Animal2>{
            //         new Dog2(),
            //         new Cat()
            //     };
            //     //vòng lặp
            //     foreach(Animal2 animal2 in animal2s){
            //         animal2.MakeSound();
            //     }
            //     Console.WriteLine($"");
            //     Console.WriteLine($"");
            //     Console.WriteLine($"");

            //     //de9_2
            //     OnDataReceivedClass orc = new OnDataReceivedClass();
            //     orc.OnDataReceived += OnDataReceivedClass.HoanThanhEvent;
            //     orc.OnDataReceived += OnDataReceivedClass.HoanThanhEvent2;
            //     orc.OnDataReceived += OnDataReceivedClass.HoanThanhEvent3;
            //     orc.BatDauEvent();
            // }

            // //de8
            // {
            //     //de8_1
            //     List<Vehicle8> vehicle8s = new List<Vehicle8>{
            //         new Car8(),
            //         new Motorbike8()
            //     };
            //     foreach (Vehicle8 vehicle8 in vehicle8s)
            //     {
            //         vehicle8.Start();
            //         vehicle8.Stop();
            //     }
            //     //de8_2
            //     Delegate8.CompareHandler compare=(a, b) => string.Compare(a, b);
            //     string a = "mama";
            //     string b = "mama";
            //     int result = compare(a, b);
            //     if (result > 0)
            //     {
            //         Console.WriteLine($"string a > string b");
            //     }
            //     else if (result < 0)
            //     {
            //         Console.WriteLine($"string a < string b");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"string a = string b");
            //     }
            // }

            // //de11
            // {
            //     //de11_1
            //     Circle11 circle11 = new Circle11();
            //     circle11.Draw();
            // }

            // //de12
            // {
            //     //de12_1
            //     List<Bird12> brid12s = new List<Bird12>{
            //         new Eagle12(),
            //         new Penguin12()
            //     };
            //     foreach (Bird12 bird12 in brid12s)
            //     {
            //         bird12.Fly12();
            //     }
            //     //de2_2
            //     //tạo đối tượng từ lớp thông báo12
            //     Notification12 notification12 = new Notification12();
            //     //tạo đối tượng từ delegate12 gán giá trị mặc null
            //     Delegate12.NotificationHandler? notificationHandler = null;
            //     //thêm pt email
            //     notificationHandler += notification12.EmailNotification;
            //     //thêm pt sms
            //     notificationHandler += notification12.SmsNotification;
            //     //gọi delegate
            //     notificationHandler();
            // }

            //de13
            {
                //de13_1
                Student13 student13 = new Student13("Truong dz");
                Teacher13 teacher13 = new Teacher13("truong zai dep");
                student13.DisplayInfo();
                teacher13.DisplayInfo();
            }

            // //de15
            // {
            //     //15a
            //     OperationDivide operationDivide = new OperationDivide();
            //     int num1 = 10;
            //     int[] num2s = [1, 2, 0, 3];
            //     foreach (int num2 in num2s)
            //     {
            //         try
            //         {
            //             Console.WriteLine($"result for {num1} / {num2} = {operationDivide.Divide(num1, num2)}");
            //         }
            //         catch (DivideByZeroException)
            //         {
            //             Console.WriteLine($"error can't be divided by 0");
            //         }
            //         catch (System.Exception ex)
            //         {
            //             Console.WriteLine($"unknown error: {ex.Message}");
            //         }
            //         finally
            //         {
            //             Console.WriteLine($"end test with num2 = {num2}" + "\n");
            //         }
            //     }
            // }

            // //de16
            // {
            //     //de16a
            //     CarPlane carPlane = new CarPlane();
            //     carPlane.Drive();
            //     carPlane.Fly();
            // }

            // //de17
            // {
            //     //17a
            //     Car car = new Car();
            //     car.StartCar();
            // }

            //

        }
    }
}
