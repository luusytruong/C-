namespace review_test
{
    class Animal2 {
        public virtual void MakeSound(){
            Console.WriteLine($"rau rau rau");
        }
    }
    class Dog2 : Animal2{
        public override void MakeSound()
        {
            Console.WriteLine($"gau gau");
        }
    }
    class Cat : Animal2{
        public override void MakeSound()
        {
            Console.WriteLine($"meo meo");
        }
    }
}
