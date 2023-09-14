using System;

namespace Lesson_5_Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isEven = "";
            Int32 number = Convert.ToInt32(Console.ReadLine());
            isEven = (number % 2 == 0) ? "Event" : "Old";
            Console.WriteLine(isEven);
            
            
        }
    }
}
