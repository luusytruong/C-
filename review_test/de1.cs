namespace review_test
{
    public class Animal
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public virtual void DisplayInfor()
        {
            Console.WriteLine($"name: {Name}, age: {Age}");
        }
    }
    public class Dog : Animal
    {
        public string? Breed { get; set; }
        public override void DisplayInfor()
        {
            Console.WriteLine($"name: {Name}, age: {Age}, breed: {Breed}");
        }
    }
}
