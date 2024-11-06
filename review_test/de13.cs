namespace review_test
{
    class Person13{
        public string? Name {get;set;}
        public Person13(string name){
            Name = name;
        }
        public  void DisplayInfo(){
            Console.WriteLine($"Name: {Name}");
        }
    }
    class Student13:Person13{
        public Student13(string name) : base(name){}
        public new void DisplayInfo(){
            Console.WriteLine($"Student: {Name}");
        }
    }
    class Teacher13:Person13{
        public Teacher13(string name) : base(name){}
        public new void DisplayInfo(){
            Console.WriteLine($"Teacher: {Name}");
        }
    }
}