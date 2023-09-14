using System;

namespace Lesson_2_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Syntax: DataType name = value;
            char a = 'a';
            int age = 10;
            double mark = 10.1;
            string myName = "khoatd";
            bool checkExits = false;

            // examples
            Console.WriteLine(a);
            Console.WriteLine(age);
            Console.WriteLine(mark);
            Console.WriteLine(myName);
            Console.WriteLine(checkExits);

            Console.WriteLine(mark + age);
        }
    }
}
