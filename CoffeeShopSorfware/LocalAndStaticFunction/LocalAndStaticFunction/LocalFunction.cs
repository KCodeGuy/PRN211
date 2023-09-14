using System;

namespace LocalAndStaticFunction
{
    internal class LocalFunction
    {
        int x = 4;
        int y = 5;
        void sumOfValue(int a, int b)
        {
            Console.WriteLine("Value of a is: " + a);
            Console.WriteLine("Value of b is: " + b);
            Console.WriteLine("Value of x is: " + x);
            Console.WriteLine("Value of y is: " + y);
            Console.WriteLine("Sum of : {0}", (a + b + x + y));
        }

        static void Main(string[] args)
        {

            sumOfValue(1, 10);
            sumOfValue(2, 4);
        }
    }
}
