using System;

// Note: comment
// 1. One line: // code here 
// 2. Many lines: /* code here */
// CommentL: ((Ctrl + k)  + (Ctrl + c))
// CommentL: ((Ctrl + k)  + (Ctrl + u))

namespace Lesson_4_MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("min is: " + Math.Max(5, 10));
            Console.WriteLine("Max is: " + Math.Min(5, 10));

            Console.WriteLine("Square of 64 is:" + Math.Sqrt(64));
            Console.WriteLine("Absolute value -5 is:" + Math.Abs(-5));
            Console.WriteLine("Pow: " + Math.Pow(2,3));

            Console.WriteLine("Pi is: " + Math.PI);
            
        }
    }
}
