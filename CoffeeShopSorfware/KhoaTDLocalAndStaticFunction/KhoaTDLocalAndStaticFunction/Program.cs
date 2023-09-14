using System;

namespace Discards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Local function
            int x = 2, y = 3;
            sumOfValue(5, 10);
            void sumOfValue(int a, int b)
            {
                Console.WriteLine($"Value of x is: {x}");
                Console.WriteLine($"Value of y is: {y}");
                Console.WriteLine($"Value of y is: {a}");
                Console.WriteLine($"Value of y is: {b}");
                Console.WriteLine($"Total: {a} + {b} + {x} + {y} = {a + b + x + y}");
                Console.WriteLine();
            }
            //sumOfValue(10, 5);

            // 2. Static local function
            //void computecirclearea(double r)
            //{
            //    Console.WriteLine("radius of circle: " + r);
            //    Console.WriteLine("area of cirle:" + (Math.PI * r * r));
            //    circumference(r);
            //    static void circumference(double radius)
            //    {
            //        Console.WriteLine("circumfernece of circle: " + (Math.PI * radius * 2));
            //    }

            //}
            //computecirclearea(2);
        }
    }
}
