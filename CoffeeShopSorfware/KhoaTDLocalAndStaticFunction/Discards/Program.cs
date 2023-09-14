using System;

namespace Discards
{
    internal class Program
    {
        static (string firstName, string middleName, string lastName) splitName(String name)
        {
            string[] str = name.Split(' ');
            return (str[0], str[1], str[2]);
        }
        
        static void Main(string[] args)
        {
            // using discard
            var (fist, _, last) = splitName("Nguyen van A");
            Console.WriteLine("fisrt name: " + fist);
            Console.WriteLine("last name: " + last);
        }
    }
}
