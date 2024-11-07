namespace review_test
{
    class BaseClass14 {
        public virtual void Display(){}
    }
    class DerivedClass14 : BaseClass14{
        public override void Display()
        {
            Console.WriteLine($"day la hien thi tu lop con");
        }
    }
}
