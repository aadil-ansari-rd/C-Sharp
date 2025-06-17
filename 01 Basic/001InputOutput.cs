using System;
namespace CSharpe_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your Second name : ");
            string secondName = Console.ReadLine();

            Console.WriteLine("Your name : {0} {1}", firstName, secondName);
            Console.WriteLine("Your name : " + firstName +" "+ secondName);
        }
    }
}
