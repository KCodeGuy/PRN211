using System;

// Note:
// 1. Chose project to run:  right mouse => set app start up project 
// 2. Short cut Console.WriteLine():  cw + tab + tab
namespace Lesson_3_Input_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //======= Output ===========
            /*string myLoverName = "Thanh Nhung";
            Console.Write(myLoverName + " , ");
            Console.WriteLine(myLoverName);*/

            Console.Write("Enter price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int total = price * number;

            // Method 1: 
            Console.WriteLine("Total 1: " + total);

            // Method 2: 
            Console.WriteLine("Total 2: {0} * {1} = {2}", price, number, total);

            // Method 3: 
            Console.WriteLine($"Total 3: {price} * {number} = {total}");

            Console.WriteLine("==============================");

            //======== Input keyboard ===========
            // 1. Input String
            
            /*Console.Write("Please input your name: ");
            string myName = Console.ReadLine();
            Console.Write("Your name is: " + myName + "\n");
            Console.WriteLine("==============================");


            // 2. Input Integer

            // Method 1: Convert to integer by Convert
            Console.Write("Please input your age 1: ");
            int myAg1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age1 is: " + myAg1);

            // Method 2: Convert to integer by System
            Console.Write("Please input your age 2: ");
            int myAge2 = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your age2 is: " + myAge2);
            Console.WriteLine("==============================");

            // 3. Input Float
            Console.Write("Please enter you mark: ");
            float myMark1 = Convert.ToSingle(Console.ReadLine());
            float myMark2 = System.Single.Parse(Console.ReadLine());
            Console.WriteLine("Your mark 1 is " + myMark1);
            Console.WriteLine("Your mark 2 is " + myMark2);*/

        }
    }
}
