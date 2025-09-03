using System;
using System.Text;

namespace StringVsStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example using string (Immutable)
            string text = "Hello";
            text += " World";   // Creates a new string object in memory
            Console.WriteLine("Using string:");
            Console.WriteLine(text);   // Output: Hello World

            // Example using StringBuilder (Mutable)
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" World");   // Modifies the same object in memory
            Console.WriteLine("\nUsing StringBuilder:");
            Console.WriteLine(sb.ToString());   // Output: Hello World
        }
    }
}
