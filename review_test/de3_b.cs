namespace review_test
{
   class MathOperationDelegate{
    public delegate int MathOperation(int a, int b);
    public int Subtract(int a, int b){
        return a - b;
    }
   }
}
