//This file jas just example for thoretical purpose and this file is not runnable. 


////✅ Example 1: Reflection – Show Properties of a Class 
//using System;
//using System.Reflection;

//namespace _28_Uses_Of_Reflection
//{
//    internal class Example1
//    {
//        static void Main(string[] args)
//        {
//            // Creating object of Person class
//            Person person = new Person();

//            // Getting Type information using Reflection
//            Type type = person.GetType();

//            Console.WriteLine("Properties of Person class using Reflection:");

//            // Looping through properties and printing names
//            foreach (PropertyInfo prop in type.GetProperties())
//            {
//                Console.WriteLine(prop.Name);
//            }
//        }
//    }

//    // Sample class with properties
//    public class Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//    }
//}





////✅ Example 2: Reflection – Late Binding (Dynamic Method Call) 
//using System;
//using System.Reflection;

//namespace _28_Uses_Of_Reflection
//{
//    internal class Example2
//    {
//        static void Main(string[] args)
//        {
//            // Class name as string
//            string className = "_28_Uses_Of_Reflection.Calculator";

//            // Getting type using reflection
//            Type type = Type.GetType(className);

//            // Creating object dynamically
//            object obj = Activator.CreateInstance(type);

//            // Getting method info using reflection
//            MethodInfo method = type.GetMethod("Add");

//            // Calling method using Invoke with parameters
//            object result = method.Invoke(obj, new object[] { 15, 25 });

//            Console.WriteLine("Result of Calculator.Add(15, 25): " + result);
//        }
//    }

//    // Class with a method to be called dynamically
//    public class Calculator
//    {
//        public int Add(int a, int b) => a + b;
//    }
//}





////✅ Example 3: Reflection – Dynamic Class Loading Based on Input
//using System;
//using System.Reflection;

//namespace _28_Uses_Of_Reflection
//{
//    internal class Example3
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter Class Name (English or Hindi): ");
//            string input = Console.ReadLine();

//            // Creating full class name with namespace
//            string fullClassName = "_28_Uses_Of_Reflection." + input;

//            // Getting type dynamically
//            Type type = Type.GetType(fullClassName);

//            if (type == null)
//            {
//                Console.WriteLine("Invalid class name entered.");
//                return;
//            }

//            // Creating instance dynamically
//            IGreet greet = (IGreet)Activator.CreateInstance(type);

//            // Calling interface method
//            greet.SayHello();
//        }
//    }

//    // Interface
//    public interface IGreet
//    {
//        void SayHello();
//    }

//    // Class 1
//    public class English : IGreet
//    {
//        public void SayHello() => Console.WriteLine("Hello!");
//    }

//    // Class 2
//    public class Hindi : IGreet
//    {
//        public void SayHello() => Console.WriteLine("Namaste!");
//    }
//}
