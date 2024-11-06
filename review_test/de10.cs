namespace review_test
{
    class Counter
    {
        public static int Count = 0;
        public static int Increment()
        {
            return Count++;
        }
    }
}