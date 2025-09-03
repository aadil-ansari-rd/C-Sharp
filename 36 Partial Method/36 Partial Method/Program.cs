using _36_Partial_Method;
using System;

namespace ParialMethodDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create object of partial class
            SamplePartialClass SPC = new SamplePartialClass();

            // Call public method that internally invokes partial methods
            SPC.PublicMethod();
        }
    }
}
