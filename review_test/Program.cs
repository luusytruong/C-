namespace review_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "tuan";
            dog.Age = 10;
            dog.Breed = "nguoi";

            dog.DisplayInfor();
        }
    }
}
