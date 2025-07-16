using System;
using System.Reflection;

namespace _29_Type_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object of TestClass
            TestClass obj = new TestClass();

            // Get Type of the object
            Type type = obj.GetType();

            Console.WriteLine("========== Reflection Using Type Class ==========\n");

            // ✅ 1. Full Name, Namespace, Base Type
            Console.WriteLine("Full Name: " + type.FullName);
            Console.WriteLine("Namespace: " + type.Namespace);
            Console.WriteLine("Base Type: " + type.BaseType + "\n");

            // ✅ 2. Constructors
            Console.WriteLine("----- Constructors -----");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (var constructor in constructors)
            {
                Console.WriteLine("Constructor: " + constructor.ToString());
            }

            // ✅ 3. Methods with Return Type
            Console.WriteLine("\n----- Methods (Return Type : Method Name) -----");
            MethodInfo[] methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " : " + method.Name);
            }

            // ✅ 4. Properties with Property Type
            Console.WriteLine("\n----- Properties (Property Type : Property Name) -----");
            PropertyInfo[] properties = type.GetProperties();
            foreach (var prop in properties)
            {
                Console.WriteLine(prop.PropertyType.Name + " : " + prop.Name);
            }

            // ✅ 5. Fields with Field Type
            Console.WriteLine("\n----- Fields (Field Type : Field Name) -----");
            FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var field in fields)
            {
                Console.WriteLine(field.FieldType.Name + " : " + field.Name);
            }

            // ✅ 6. Interfaces
            Console.WriteLine("\n----- Interfaces -----");
            Type[] interfaces = type.GetInterfaces();
            foreach (var iface in interfaces)
            {
                Console.WriteLine("Interface: " + iface.Name);
            }

            Console.WriteLine("\n========== Reflection Completed ==========");
        }
    }

    // ✅ Custom Class with Constructors, Methods, Properties, Field
    public interface IDummy { }

    public class TestClass : IDummy
    {
        private int secretNumber = 99;  // Private field

        public string Name { get; set; }  // Property 1
        public int Age { get; set; }      // Property 2

        public TestClass()
        {
            Name = "Default Name";
            Age = 25;
        }

        public TestClass(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()  // Method 1
        {
            Console.WriteLine("Name: " + Name + ", Age: " + Age);
        }

        public int CalculateYearOfBirth(int currentYear)  // Method 2
        {
            return currentYear - Age;
        }
    }
}


//// OUTPUT

//========== Reflection Using Type Class ==========
//Full Name: _29_Type_Class.TestClass
//Namespace: _29_Type_Class
//Base Type: System.Object

//----- Constructors -----
//Constructor: Void .ctor()
//Constructor: Void .ctor(System.String, Int32)

//----- Methods (Return Type : Method Name) -----
//String : get_Name
//Void : set_Name
//Int32 : get_Age
//Void : set_Age
//Void : DisplayInfo
//Int32 : CalculateYearOfBirth
//Type : GetType
//String : ToString
//Boolean : Equals
//Int32 : GetHashCode

//----- Properties (Property Type : Property Name) -----
//String : Name
//Int32 : Age

//----- Fields (Field Type : Field Name) -----
//Int32 : secretNumber
//String : <Name>k__BackingField
//Int32 : <Age>k__BackingField

//----- Interfaces -----
//Interface: IDummy

//========== Reflection Completed ==========




//-----------------------------------------------------------------------------------------------------

////Topic: Different Ways to Get Type Information in C# using Reflection

//This program demonstrates four different ways to get Type information of a class in C# using Reflection:
//1. typeof() Operator
//2. obj.GetType() Method
//3. Type.GetType(string) Method
//4. Assembly.GetType() Method


//Example ( With syntax ) -----------------------------------------


//using System;
//using System.Reflection;

//namespace Type_Reflection_Sample
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // ✅ 1. typeof() Operator → Compile time Type
//            Type type1 = typeof(TestClass);
//            Console.WriteLine("typeof() : " + type1.FullName);

//            // ✅ 2. obj.GetType() → Runtime Type from object
//            TestClass obj = new TestClass();
//            Type type2 = obj.GetType();
//            Console.WriteLine("GetType() : " + type2.FullName);

//            // ✅ 3. Type.GetType() → Type using string (dynamic)
//            Type type3 = Type.GetType("Type_Reflection_Sample.TestClass");
//            Console.WriteLine("Type.GetType() : " + type3.FullName);

//            // ✅ 4. Assembly.GetType() → From current assembly
//            Assembly asm = Assembly.GetExecutingAssembly();
//            Type type4 = asm.GetType("Type_Reflection_Sample.TestClass");
//            Console.WriteLine("Assembly.GetType() : " + type4.FullName);
//        }
//    }

//    // ✅ Class with simple structure
//    public class TestClass
//    {
//        public string Name { get; set; }
//    }
//}
