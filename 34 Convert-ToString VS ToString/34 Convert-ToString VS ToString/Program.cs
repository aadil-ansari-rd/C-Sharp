using System;

namespace ToStringVsConvertToString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example with a normal string
            string name = "Aadil";

            Console.WriteLine("Using ToString() with non-null value:");
            Console.WriteLine(name.ToString());   // Output: Aadil

            Console.WriteLine("\nUsing Convert.ToString() with non-null value:");
            Console.WriteLine(Convert.ToString(name));   // Output: Aadil

            // Example with a null string
            string nullString = null;

            Console.WriteLine("\nUsing ToString() with null value:");
            try
            {
                Console.WriteLine(nullString.ToString());  // Throws NullReferenceException
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.WriteLine("\nUsing Convert.ToString() with null value:");
            Console.WriteLine(Convert.ToString(nullString));  // Output: (empty string)
        }
    }
}
