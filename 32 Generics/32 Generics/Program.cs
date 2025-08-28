// Example : 1
namespace _32_Generics
{
    // 1. Using Object type parameters (not type safe, performance issue)
    public class CompareWithObject
    {
        public static bool AreEqual(object value1, object value2)
        {
            return value1.Equals(value2);
        }
    }

    // 2. Using Method Generics (type safe, no boxing/unboxing)
    public class GenericsMethod
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    // 3. Generic Class Example
    public class GenericsClass<T>
    {
        public  bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // --- Object type usage (Not type safe)
            bool result1 = CompareWithObject.AreEqual(10, "10"); // Compiles but meaningless
            Console.WriteLine("Object Type AreEqual(10, \"10\") => " + result1);

            bool result2 = CompareWithObject.AreEqual(10, 10);
            Console.WriteLine("Object Type AreEqual(10, 10) => " + result2);

            // --- Generic method usage (Type safe)
            bool genericResult1 = GenericsMethod.AreEqual<int>(10, 10);
            Console.WriteLine("Generic Method AreEqual<int>(10, 10) => " + genericResult1);

            bool genericResult2 = GenericsMethod.AreEqual<string>("Hello", "World");
            Console.WriteLine("Generic Method AreEqual<string>(\"Hello\", \"World\") => " + genericResult2);

            // --- Generic class usage
            GenericsClass<int> intCompare = new GenericsClass<int>();
            Console.WriteLine("Generic Class AreEqual<int>(10, 10) => " + intCompare.AreEqual(10,10));


            GenericsClass<string> stringCompare = new GenericsClass<string>();
            Console.WriteLine("Generic Class AreEqual<string>(\"Hello\", \"World\") => " + stringCompare.AreEqual("Hello", "World"));

        }
    }
}




// Example : 2

//namespace _32_Generics
//{
//    // 1. Using Object type parameters (not type safe, performance issue)
//    public class CalculatorWithObject
//    {
//        public static bool AreEqual(object value1, object value2)
//        {
//            return value1.Equals(value2);
//        }
//    }

//    // 2. Using Method Generics (type safe, no boxing/unboxing)
//    public class CalculatorWithGenerics
//    {
//        public static bool AreEqual<T>(T value1, T value2)
//        {
//            return value1.Equals(value2);
//        }
//    }

//    // 3. Generic Class Example
//    public class GenericStorage<T>
//    {
//        private T data;

//        public void SetValue(T value)
//        {
//            data = value;
//        }

//        public T GetValue()
//        {
//            return data;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // --- Object type usage (Not type safe)
//            bool result1 = CalculatorWithObject.AreEqual(10, "10"); // Compiles but meaningless
//            Console.WriteLine("Object Type AreEqual(10, \"10\") => " + result1);

//            bool result2 = CalculatorWithObject.AreEqual(10, 10);
//            Console.WriteLine("Object Type AreEqual(10, 10) => " + result2);

//            // --- Generic method usage (Type safe)
//            bool genericResult1 = CalculatorWithGenerics.AreEqual<int>(10, 10);
//            Console.WriteLine("Generic Method AreEqual<int>(10, 10) => " + genericResult1);

//            bool genericResult2 = CalculatorWithGenerics.AreEqual<string>("Hello", "World");
//            Console.WriteLine("Generic Method AreEqual<string>(\"Hello\", \"World\") => " + genericResult2);

//            // --- Generic class usage
//            GenericStorage<int> intStorage = new GenericStorage<int>();
//            intStorage.SetValue(100);
//            Console.WriteLine("Generic Class stored int => " + intStorage.GetValue());

//            GenericStorage<string> stringStorage = new GenericStorage<string>();
//            stringStorage.SetValue("Generics in C#");
//            Console.WriteLine("Generic Class stored string => " + stringStorage.GetValue());
//        }
//    }
//}
