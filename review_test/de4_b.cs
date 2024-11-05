namespace review_test
{
    class CalculationHandlerDelegate
    {
        public delegate int CalculationHandler(int a, int b);
        public int Multiply(int a, int b)
        {
            int result = a*b;
            Console.WriteLine($"phep nhan {a} va {b}: {result}");
            OnCalculationComplete?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public event EventHandler? OnCalculationComplete;
        public static void OnCompleted(object? sender, EventArgs e){
            Console.WriteLine($"phep nhan da hoan thanh");
        }
    }
}
