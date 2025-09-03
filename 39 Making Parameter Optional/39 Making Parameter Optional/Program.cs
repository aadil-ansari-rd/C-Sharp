//////Example : Using Parameter Array (params) to Make Parameters Optional


using System;
class Program
{
    // First two parameters are mandatory, rest are optional via params
    static int Sum(int a, int b, params int[] extraNumbers)
    {
        int result = a + b;  // add mandatory ones first

        // Add any optional numbers if provided
        foreach (int num in extraNumbers)
        {
            result += num;
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine(Sum(5, 10));              // Only 2 → 15
        Console.WriteLine(Sum(5, 10, 20));          // 3 numbers → 35
        Console.WriteLine(Sum(1, 2, 3, 4, 5));      // Many numbers → 15
    }
}






////---------------------------------------------------------------------------------------------
//////Example : Using Method Overloading to Make Parameters Optional


//using System;
//class Program
//{
//    // Version 1: Exactly 2 parameters
//    static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    // Version 2: 2 mandatory + optional numbers using params
//    static int Sum(int a, int b, params int[] extraNumbers)
//    {
//        int result = a + b;

//        foreach (int num in extraNumbers)
//        {
//            result += num;
//        }

//        return result;
//    }

//    static void Main()
//    {
//        Console.WriteLine(Sum(5, 10));              // Uses Version 1 → 15
//        Console.WriteLine(Sum(5, 10, 20));          // Uses Version 2 → 35
//        Console.WriteLine(Sum(1, 2, 3, 4, 5));      // Uses Version 2 → 15
//    }
//}



////---------------------------------------------------------------------------------------------
//////Example : Using Default Parameters to Make Parameters Optional


//using System;
//class Program
//{
//    // At least 2 mandatory parameters, third is optional with default = 0
//    static int Sum(int a, int b, int c = 0, params int[] extraNumbers)
//    {
//        int result = a + b + c;  // add mandatory + defaulted param

//        // Add any extra optional numbers if provided
//        foreach (int num in extraNumbers)
//        {
//            result += num;
//        }

//        return result;
//    }

//    static void Main()
//    {
//        Console.WriteLine(Sum(5, 10));                 // a=5, b=10, c=0 → 15
//        Console.WriteLine(Sum(5, 10, 20));             // a=5, b=10, c=20 → 35
//        Console.WriteLine(Sum(1, 2, 3, 4, 5));         // a=1, b=2, c=3, extras={4,5} → 15
//    }
//}



////---------------------------------------------------------------------------------------------
//////Example : Using Named Parameters to Make Parameters Optional


//using System;
//class Program
//{
//    // Two required parameters, one optional with default, and params for extras
//    static int Sum(int a, int b, int c = 0, params int[] extraNumbers)
//    {
//        int result = a + b + c;

//        foreach (int num in extraNumbers)
//        {
//            result += num;
//        }

//        return result;
//    }

//    static void Main()
//    {
//        // Only required parameters
//        Console.WriteLine(Sum(a: 5, b: 10));              // 15

//        // Using named parameter to pass c explicitly
//        Console.WriteLine(Sum(a: 5, b: 10, c: 20));       // 35

//        // Skipping c (defaults to 0), directly using params
//        Console.WriteLine(Sum(a: 1, b: 2, extraNumbers: new int[] { 3, 4, 5 })); // 15
//    }
//}



////---------------------------------------------------------------------------------------------
//////Example : Using[Optional] Attribute to Make Parameters Optional


//using System;
//using System.Runtime.InteropServices;
//class Program
//{
//    // Two required parameters, one optional using [Optional], and params for extras
//    static int Sum(int a, int b, [Optional] int c, params int[] extraNumbers)
//    {
//        int result = a + b;

//        // If 'c' is not passed, it will be default(int) = 0
//        result += c;

//        foreach (int num in extraNumbers)
//        {
//            result += num;
//        }

//        return result;
//    }

//    static void Main()
//    {
//        Console.WriteLine(Sum(5, 10));               // Only 2 → 15
//        Console.WriteLine(Sum(5, 10, 20));           // 3 numbers → 35
//        Console.WriteLine(Sum(1, 2, 3, 4, 5));       // Many numbers → 15
//    }
//}
