namespace review_test
{
    //create class
    public class OperationDelegate
    {
        //2a create delegate
        public delegate int Operation(int a, int b);
        //2b create func add
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
