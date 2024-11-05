using System.Runtime.InteropServices;

namespace review_test
{
    class MODelegate
    {
        public delegate double MathOperation(int a, int b);
        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            return a / b;
        }
    }
}
