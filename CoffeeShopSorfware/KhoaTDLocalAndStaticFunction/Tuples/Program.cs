using System;
using System.Linq;
using System.Reflection;

namespace Tuples
{
    internal class Program
    {
        static (int max, int index) findMaxAndIndex(int[] arr)
        {
            var result = (max: arr[0] , index:0);
            int lenght = arr.Length;
            for(int i = 1; i < lenght; i++)
            {
                if (arr[i] > result.max)
                {
                    result.max = arr[i];
                    result.index = i;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            // 1. declare variables
            //(string name, int age) myInfo = ("khoaTD", 20);
            //Console.WriteLine("My name: " + myInfo.name);
            //Console.WriteLine("My age: " + myInfo.age);
            //Console.WriteLine(myInfo);

            // 2 . examples 
            int[] arr = { 2, 1, 5, 6, 3 };
            var (max, index) = findMaxAndIndex(arr);
            Console.WriteLine($"Max of arr: {max}");
            Console.WriteLine($"Index of max: {index}");

        }
    }
}
