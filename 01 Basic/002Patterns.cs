using System;
namespace CSharpe_Basics
{
    internal class Program
    {
//* * * * *
//* * * * *
//* * * * *
//* * * * *
//* * * * *
        static void Main(string[] args)
        {
            int n = 5;
            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
