namespace review_test;

//viết ra file khác tương tự viết ở trên này
internal class Program
{
    //đi thi viết ở đây
    static void Main(string[] args)
    {
        //de1 1
        {
            // //khởi tạo dt dog từ lớp Dog
            // Dog dog = new Dog();
            // //đặt thuộc tính bằng dog.key = value (key là tt, pt trong lớp animal và dog)
            // dog.Name = "ngoc";
            // dog.Age = 10;
            // dog.Breed = "rau";
            // dog.DisplayInfor();
            // //đầu ra "name: ngoc, age: 10, breed: rau"

            // //de1 2
            // //khởi tạo đối tượng của lớp OperationDelegate
            // OperationDelegate opd = new OperationDelegate();
            // //2c sử dụng dlg để tham chiếu đến pt Add()
            // OperationDelegate.Operation op = new OperationDelegate.Operation(opd.Add);
            // //2d sử dụng dlg để tính tổng 2 số
            // Console.WriteLine($"Sum 2 numbers: {op(10, 1)}");
            // //đầu ra "Sum 2 numbers: 11"
        }
        //de2 
        {
            // //2d sd tính đa hình để tạo ds các dt Shape và gọi pt Draw()
            // List<Shape> shapes = new List<Shape>{
            //     //tao dt hinh tron
            //     new Circle(),
            //     //tao dt hinh vuong
            //     new Rectangle()
            //     };
            // //vòng lặp tạo 1 đối tượng là shape có kiểu Shape nằm trong shapes 
            // foreach (Shape shape in shapes)
            // {
            //     //gọi pt Draw() cho từng dt trong list
            //     shape.Draw();
            // }
            // //đầu ra "ve mot hinh tron, ve mot hinh chu nhat"

            // //de2_b
            // //2d tạo dt của task và khoat event OnCompleted
            // Task task = new Task();
            // //đăng ký pt xly event
            // task.OnCompleted += Task.TaskCompletedHandler;
            // //kích hoạt event OnCompleted
            // task.CompleteTask();
        }
        //de3
        {
            // //3a
            // Account account = new Account();
            // Console.WriteLine($"tien cua tai khoan la: {account.Init(2)}");
            // Console.WriteLine($"tien cua tai khoan sau khi them: {account.Deposit(100)}");
            // Console.WriteLine($"tien cua tai khoan sau khi rut: {account.WithDraw(10)}");
            // //3b
            // MathOperationDelegate mod = new MathOperationDelegate();
            // MathOperationDelegate.MathOperation sub = new MathOperationDelegate.MathOperation(mod.Subtract);
            // Console.WriteLine($"phep tru 2 so: {sub(10, 1)}");
        }
        //de4
        {
            // //4d
            // Manager manager = new Manager();
            // Console.WriteLine($"Manager: Name: {manager.Name = "Ngọc râu"}, Position: {manager.Position = "quản lý"}, Department: {manager.Department = "p quản lý"}");
            // Developer developer = new Developer();
            // Console.WriteLine($"Developer: Name: {developer.Name = "Ngọc râu 2"}, Position: {developer.Position = "lập trình viên"}, Department: {developer.ProgrammingLanguage = "ngôn ngữ C#"}");

            // //4_b
            // CalculationHandlerDelegate chd = new CalculationHandlerDelegate();
            // CalculationHandlerDelegate.CalculationHandler mul = new CalculationHandlerDelegate.CalculationHandler(chd.Multiply);
            // chd.OnCalculationComplete += CalculationHandlerDelegate.OnCompleted;
            // mul(2, 8);
        }
        //de5
        {
            // List<IMovable> movables = new List<IMovable>{
            //         new Car5(),
            //         new Bike5()
            //     };
            // foreach (IMovable movable in movables)
            // {
            //     movable.Move();
            // }
        }
        //de6
        {
            // List<Appliance> appliances = new List<Appliance>{
            //         new WashingMachine(),
            //         new Refrigerator()
            //     };
            // foreach (Appliance appliance in appliances)
            // {
            //     appliance.TurnOn();
            //     appliance.TurnOff();
            // }
            // //de6_2
            // //phương thức vô danh (anonymous method) thực hiện phép chia
            // Delegate6.MathOperation Divide = delegate (double x, double y)
            // {
            //     return x / y;
            // };
            // //biểu thức lambda để thực hiện phép nhân
            // Delegate6.MathOperation Multiply = (x, y) => x * y;

            // //thực hiện các phép tính
            // int a = 10;
            // int b = 0;
            // Console.WriteLine($"phep chia pt vo danh: {a}/{b} = {Divide(a, b)}");
            // Console.WriteLine($"phep nhan bieu thuc lambda: {a}*{b} = {Multiply(a, b)}");
        }
        //de7
        {
            // //de7_1
            // Person person1 = new Person();
            // person1.DisplayInfo();
            // Person person2 = new Person("Ngoc rau", 10);
            // person2.DisplayInfo();
            // //de7_2
            // MODelegate modd = new MODelegate();
            // MODelegate.MathOperation divide = new MODelegate.MathOperation(modd.Divide);
            // Console.WriteLine($"phep chia 10 va 2: {divide(10, 2)}");
        }
        //de10
        {
            // //de10_1
            // Counter counter = new Counter();
            // Counter counter1 = new Counter();

            // Counter.Increment();
            // Counter.Increment();

            // Console.WriteLine($"so lan goi pt: {Counter.Count}");

            // //de10_2
            // CalculationHandlerAdd cha = new CalculationHandlerAdd();
            // CalculationHandlerAdd.CalculationHandler sum = cha.Add;
            // sum(10, 99);
        }
        //de9
        {
            // //de9_1
            // List<Animal2> animal2s = new List<Animal2>{
            //         new Dog2(),
            //         new Cat()
            //     };
            // //vòng lặp
            // foreach (Animal2 animal2 in animal2s)
            // {
            //     animal2.MakeSound();
            // }
            // Console.WriteLine($"");
            // Console.WriteLine($"");
            // Console.WriteLine($"");

            // //de9_2
            // OnDataReceivedClass orc = new OnDataReceivedClass();
            // orc.OnDataReceived += OnDataReceivedClass.HoanThanhEvent;
            // orc.OnDataReceived += OnDataReceivedClass.HoanThanhEvent2;
            // orc.OnDataReceived += OnDataReceivedClass.HoanThanhEvent3;
            // orc.BatDauEvent();
        }
        //de8
        {
            // //de8_1
            // List<Vehicle8> vehicle8s = new List<Vehicle8>{
            //         new Car8(),
            //         new Motorbike8()
            //     };
            // foreach (Vehicle8 vehicle8 in vehicle8s)
            // {
            //     vehicle8.Start();
            //     vehicle8.Stop();
            // }
            // //de8_2
            // Delegate8.CompareHandler compare = (a, b) => string.Compare(a, b);
            // string a = "mama";
            // string b = "mama";
            // int result = compare(a, b);
            // if (result > 0)
            // {
            //     Console.WriteLine($"string a > string b");
            // }
            // else if (result < 0)
            // {
            //     Console.WriteLine($"string a < string b");
            // }
            // else
            // {
            //     Console.WriteLine($"string a = string b");
            // }
        }
        //de11
        {
            // //de11_1
            // Circle11 circle11 = new Circle11();
            // circle11.Draw();
        }
        //de12
        {
            // //de12_1
            // List<Bird12> brid12s = new List<Bird12>{
            //         new Eagle12(),
            //         new Penguin12()
            //     };
            // foreach (Bird12 bird12 in brid12s)
            // {
            //     bird12.Fly12();
            // }
            // //de2_2
            // //tạo đối tượng từ lớp thông báo12
            // Notification12 notification12 = new Notification12();
            // //tạo đối tượng từ delegate12 gán giá trị mặc null
            // Delegate12.NotificationHandler? notificationHandler = null;
            // //thêm pt email
            // notificationHandler += notification12.EmailNotification;
            // //thêm pt sms
            // notificationHandler += notification12.SmsNotification;
            // //gọi delegate
            // notificationHandler();
        }
        //de13
        {
            // //de13_1
            // Student13 student13 = new Student13("Truong dz");
            // Teacher13 teacher13 = new Teacher13("truong zai dep");
            // student13.DisplayInfo();
            // teacher13.DisplayInfo();
        }
        //de14
        {
            // BaseClass14 baseClass14 = new BaseClass14();
            // baseClass14.Display();
            // DerivedClass14 derivedClass14 = new DerivedClass14();
            // derivedClass14.Display();

            // //de14_2
            // Process14 process14 = new Process14();
            // process14.OnProcessCompleted += Process14.NotificationOnComplete;
            // process14.CompleteProcess();
        }
        //de15
        {
            // //15a
            // OperationDivide operationDivide = new OperationDivide();
            // int num1 = 10;
            // int[] num2s = [1, 2, 0, 3];
            // foreach (int num2 in num2s)
            // {
            //     try
            //     {
            //         Console.WriteLine($"result for {num1} / {num2} = {operationDivide.Divide(num1, num2)}");
            //     }
            //     catch (DivideByZeroException)
            //     {
            //         Console.WriteLine($"error can't be divided by 0");
            //     }
            //     catch (System.Exception ex)
            //     {
            //         Console.WriteLine($"unknown error: {ex.Message}");
            //     }
            //     finally
            //     {
            //         Console.WriteLine($"end test with num2 = {num2}" + "\n");
            //     }
            // }
        }
        //de16
        {
            // //de16a
            // CarPlane carPlane = new CarPlane();
            // carPlane.Drive();
            // carPlane.Fly();
        }
        //de17
        {
            // //17a
            // Car car = new Car();
            // car.StartCar();
        }
        //de18
        {
            // List<IDrive18> drive18s = new List<IDrive18>{
            //         new Car18(),
            //         new Truck18()
            //     };

            // foreach (IDrive18 drive18 in drive18s)
            // {
            //     drive18.Drive();
            // }
        }
        //de19
        {
            // Fan19 fan19 = new Fan19();
            // AirConditioner19 airConditioner19 = new AirConditioner19();
            // fan19.TurnOn();
            // airConditioner19.TurnOn();
        }
        //de20
        {
            // //de20_1
            // Car20 car20 = new Car20();
            // car20.Start();
        }
        {
            // //de21_1
            // Helicopter21 helicopter21 = new Helicopter21();
            // helicopter21.Move();
            // helicopter21.Fly();
            // //de21_2
            // Event21 event21 = new Event21();
            // event21.OnMessageReceived += Event21.NotificationOnReceived;
            // event21.ReceiveMessage();
        }
        {
            // //de22_1
            // BankAccount22 bankAccount22 = new BankAccount22(1);
            // bankAccount22.Deposit(100);
            // bankAccount22.WithDraw(9);
            // //22_2
            // Event22 event22 = new Event22();
            // event22.OnTemperatureChanged += Event22.NotificationUpdateTemperature;
            // event22.UpdateTemperature();
        }
        {
            // //de23_1
            // Person23 person23 = new Person23("Truong dz");
            // Person23 person234 = new Person23("Truong dz qua ay", 16);
            // // de23_2
            // Event23 event23 = new Event23();
            // event23.OnGameOver += Event23.NotificationOnGameOver;
            // event23.EndGame();
        }
        {
            // de24_1
            // List<Instrument24> instrument24s = new List<Instrument24>{
            //     new Guitar24(),
            //     new Piano24()
            // };
            // foreach (Instrument24 instrument24 in instrument24s)
            // {
            //     instrument24.Play();
            // }
            // // de24_2
            // Delegate24 delegate24 = new Delegate24();
            // Delegate24.NotificationHandler? multicastDelegate = null;
            // multicastDelegate += delegate24.EmailNotification;
            // multicastDelegate += delegate24.SMSNotification;
            // multicastDelegate();
        }
        {
            // // de25_1
            // Car25 car25 = new Car25("1909", "Bugatti");
            // car25.DisplayInfo();
            // Car25 car26 = new Car25("1926", "Mercedes");
            // car26.DisplayInfo();
            // Car25 car27 = new Car25("1931", "Porsche");
            // car27.DisplayInfo();
            // Car25 car28 = new Car25("1963", "Lamborghini");
            // car28.DisplayInfo();
            // // de25_2
            // Delegate25 delegate25 = new Delegate25();
            // Delegate25.MathOperation sum = delegate25.Add;
            // sum(10, 2);
        }
        {
            // // de27_1
            // Dog27 dog27 = new Dog27("Ngoc", "co rau");
            // dog27.DisplayInfo();
            // //de27_2
            // Task27 task27 = new Task27();
            // task27.OnFinished += Task27.NotificationOnFinished;
            // task27.CompletedTask();
        }
        {
            // // de28_1
            // Person28 person28 = new Person28("Ngoc rau", 200);
            // // de28_2
            // Sensor28 sensor28 = new Sensor28();
            // sensor28.OnSensorTriggered += Sensor28.NotificationOnTrigeerdSensor;
            // sensor28.TriggeredSensor();
        }
        {
            // // de29_1
            // Student29 student29 = new Student29("Truong dep trai so 1");
            // // de29_2
            // Delegate29 delegate29 = new Delegate29();
            // Delegate29.Operation multiply = delegate29.Multiply;
            // multiply(10, 22);
        }
        {
            // // de30_1
            // Circle30 circle30 = new Circle30();
            // circle30.Draw();
            // // de30_2
            // Process30 process30 = new Process30();
            // process30.OnProcessCompleted += Process30.NotificationOnFinishedProcess;
            // process30.FinishProcess();
        }
        {
            // // de31_1
            // Account31 account31 = new Account31(0);
            // account31.Deposit(100);
            // account31.WithDraw(1);
            // // de31_2
            // Delegate31 delegate31 = new Delegate31();
            // Delegate31.CalculationHandler subtract = delegate31.Subtract;
            // subtract(10, 2);
        }
        {
            // // de32_1
            // Car32 car32 = new Car32();
            // Bike32 bike32 = new Bike32();
            // car32.Drive();
            // bike32.Drive();
            // // de32_2
            // Delegate32.MathOperation add = (a, b) => a + b;
            // Console.WriteLine($"phep cong 2 so: {add(10, 5)}");
        }
        {
            // // de33_1
            // Product33 product33 = new Product33("iphone X", 90);
            // // de33_2
            // Alram33 alram33 = new Alram33();
            // alram33.OnAlarmRang += Alram33.NotificationOnRingAlarm;
            // alram33.RingAlarm();
        }
        {
            // // de34_1
            // Caculator34 caculator34 = new Caculator34();
            // caculator34.Add(10, 2);
            // caculator34.Add(10.0, 4.0);
            // // de34_2
            // GameLevel34 gameLevel34 = new GameLevel34();
            // gameLevel34.OnLevelCompleted += GameLevel34.NotificationOnLevelCompleted;
            // gameLevel34.CompleteLevel();
            // //de34_2_2
            // GameLevel34_2 gameLevel34_2 = new GameLevel34_2();
            // gameLevel34_2.OnLevelCompleted += () => Console.WriteLine($"da hoan thanh cap do");
            // gameLevel34_2.CompleteLevel();
        }
        {
            // // de35_1
            // Book35 book35 = new Book35("Tam cam", "kim dong");
            // Console.WriteLine($"Author: {book35.Author}, Title: {book35.Title}");
            // // de35_2
            // DataProcess35 dataProcess35 = new DataProcess35();
            // dataProcess35.OnDataProcessed += () => Console.WriteLine($"du lieu da duoc xu ly thanh cong");
            // dataProcess35.ProcessData();
        }
        {
            // // de36_1
            // Game36 game36 = new Game36();
            // Music36 music36 = new Music36();
            // game36.Play();
            // music36.Play();
            // // de36_2
            // Phone36 phone36 = new Phone36();
            // phone36.OnCallReceived += () => Console.WriteLine($"da nhan cuoc goi den");
            // phone36.ReceivedCall();
        }
        {
            // // de37_1
            // Laptop37 laptop37 = new Laptop37();
            // laptop37.Brand = "ASUS";
            // laptop37.Price = 10;
            // laptop37.ShowInfo();
            // // de37_2
            // Delegate37 delegate37 = new Delegate37();
            // Delegate37.MathOperation multiply = delegate37.Multiply;
            // multiply(9, 3);
        }
        {
            // // de38_1
            // Animal38 animal38 = new Animal38();
            // Car38 car38 = new Car38();
            // animal38.Run();
            // car38.Run();
            // // de38_2
            // EmailSender38 emailSender38 = new EmailSender38();
            // emailSender38.OnEmailSent += () => Console.WriteLine($"email da duoc gui thanh cong");
            // emailSender38.SendEmail();
        }
        {
            // // de39_1
            // Car39 car39 = new Car39();
            // Bike39 bike39 = new Bike39();
            // car39.Drive();
            // bike39.Drive();
            // // de39_2
            // Delegate39 delegate39 = new Delegate39();
            // Delegate39.CaculationHandler multiply = delegate39.Multiply;
            // multiply(13, 5);
        }
        {
            // // de40_1
            // Product40 product40 = new Product40("Laptop", 10);
            // // de40_2
            // Delegate40 delegate40 = new Delegate40();
            // Delegate40.OperationHandler divide = delegate40.Divide;
            // Console.WriteLine($"ket qua cua phep chia: 5 / 0 = {divide(5, 0)}");
        }
        {
            // // de41_1
            // Caculator41 caculator41 = new Caculator41();
            // caculator41.Add(10, 2);
            // caculator41.Add(10.0, 2.0);
            // // de41_2
            // Delegate41 delegate41 = new Delegate41();
            // Delegate41.CaculatorHandler multiply = delegate41.Multiply;
            // multiply(10, 9);
        }
        {
            // // de42_1
            // Book42 book42 = new Book42("tam cam", "kim dong");
            // // de42_2
            // Delegate42 delegate42 = new Delegate42();
            // Delegate42.OperationHandler add = delegate42.Add;
            // add(10, 1);
        }
        {
            // // de43_1
            // Manager43 manager43 = new Manager43();
            // Developer43 developer43 = new Developer43();
            // manager43.Work();
            // developer43.Work();
            // // de43_2
            // Delegate43 delegate43 = new Delegate43();
            // Delegate43.MathOperation subtract = delegate43.Subtract;
            // subtract(10, 1);
        }
        {
            // // de44_1
            // Cat44 cat44 = new Cat44("Dao van ngoc", "brown");
            // // de44_2
            // Delegate44 delegate44 = new Delegate44();
            // Delegate44.OperationHandler multiply = delegate44.Multiply;
            // multiply(10, 1);
        }
        {
            // de45_1
            Game45 game45 = new Game45();
            Music45 music45 = new Music45();
            game45.Play();
            music45.Play();
            // de45_2
            Delegate45 delegate45 = new Delegate45();
            Delegate45.MathOperation add = delegate45.Add;
            add(10, 1);
        }
    }
}


