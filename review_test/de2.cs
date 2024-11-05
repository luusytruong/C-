namespace review_test
{
    //1a: kh có nội dung = abstract
    public abstract class Shape{
        public abstract void Draw();
    }
    //1b
    public class Circle : Shape{
        public override void Draw()
        {
            Console.WriteLine($"ve mot hinh tron");
        }
    }
    //1c
    public class Rectangle : Shape{
        public override void Draw()
        {
            Console.WriteLine($"ve mot hinh chu nhat");
        }
    }
}
