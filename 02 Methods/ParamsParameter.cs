using System;
using System.Net.Http.Headers;
namespace CSharpe_Basics
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] Numbers = {1, 2, 3, 4, 5};
            ParamsParameter(Numbers);
            ParamsParameter(10, 20, 30, 40, 50);
            ParamsParameter(); 
        }
        public static void ParamsParameter(params int[] param)
        {
            foreach (int i in param)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
           
    }
}
