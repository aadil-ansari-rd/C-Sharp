
namespace _ToString
{
    // Person class without ToString() override
    public class Person0
    {
        public string Name { get; set; }
        public int Age { get; set; }
        // No ToString() override here
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Overriding ToString()
        public override string ToString()
        {
            return $"Person Name: {Name}, Age: {Age}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person0 p0 = new Person0 { Name = "Aadil", Age = 18 };

            // Print using Convert.ToString()
            Console.WriteLine(Convert.ToString(p0));
            // Print using .ToString()
            Console.WriteLine(p0.ToString());
            // Print using object directly
            Console.WriteLine(p0);

            Person p1 = new Person { Name = "Aadil", Age = 18 };
            Person p2 = new Person { Name = "Rohit", Age = 25 };

            // When we print objects directly, ToString() is called
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            // Explicit call (same result)
            Console.WriteLine(p1.ToString());


        }
    }
}




