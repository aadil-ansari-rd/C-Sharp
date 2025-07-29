using System;
using System.Reflection;

namespace LateBindingExample
{
    public class Calculator
    {
        public void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            // Load the current assembly (you can also load from DLL)
            Assembly asm = Assembly.GetExecutingAssembly();

            // Get type information
            Type calcType = asm.GetType("LateBindingExample.Calculator");

            // Create an instance dynamically
            object calcInstance = Activator.CreateInstance(calcType);

            // Invoke Greet method (void method)
            MethodInfo greetMethod = calcType.GetMethod("Greet");
            greetMethod.Invoke(calcInstance, new object[] { "Aadil" });

            // Invoke Add method (returns int)
            MethodInfo addMethod = calcType.GetMethod("Add");
            object result = addMethod.Invoke(calcInstance, new object[] { 5, 7 });

            Console.WriteLine("Addition Result: " + result);
        }
    }
}
