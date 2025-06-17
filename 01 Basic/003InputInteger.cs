using System;
namespace CSharpe_Basics
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is : {0}", age);
        }
    }
}
