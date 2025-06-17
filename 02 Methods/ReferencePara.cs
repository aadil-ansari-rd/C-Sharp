using System;
namespace CSharpe_Basics
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int value = 0;
            ReferenceParameter(ref value);
            Console.WriteLine(value);
        }
        public static void ReferenceParameter(ref int value) {
            value = 105;
        }
           
    }
}
