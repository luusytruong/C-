namespace review_test
{
    class CalculationHandlerAdd
    {
        public delegate int CalculationHandler(int a, int b);
        public int Add(int a, int b)
        {
            Console.WriteLine($"phep cong {a} va {b}: {a + b}");
            return a + b;
        }
    }
}
