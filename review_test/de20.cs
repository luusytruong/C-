namespace review_test
{
    class Engine20
    {
        public void Start()
        {
            Console.WriteLine($"dong co da khoi dong");
        }
    }
    class Vehicle20
    {
        public Engine20 Engine20 {get;set;}
        public Vehicle20(){
            Engine20 = new Engine20();
        }
    }
    class Car20 : Vehicle20
    {
        public void Start(){
            Engine20.Start();
            Console.WriteLine($"xe dang chay");
        }
    }
}