using System;
namespace CSharpe_Basics
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int value = 0;
            ValueParameter(value);
            Console.WriteLine(value);
        }
        public static void ValueParameter(int value) {
            value = 105;
        }
           
    }
}
