using System;
using System.Net.Http.Headers;
namespace CSharpe_Basics
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int TotalSum=0, TotalProduct =0;
            OutParameter(10, 20,out TotalSum,out TotalProduct);
            Console.WriteLine("Sum = {0} & Product = {1} ",TotalSum,TotalProduct);
        }
        public static void OutParameter(int FN , int SN , out int Sum, out int Product) {
            Sum = FN + SN;
            Product = FN * SN;
        }
           
    }
}
