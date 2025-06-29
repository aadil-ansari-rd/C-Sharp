
////Multicast Simple Example
//public delegate void SampleMethod();
//public class Program
//{
//    public static void Main()
//    {
//        //Approcach 1
//        SampleMethod del1, del2, del3, del4;
//        del1 = new SampleMethod(SampleMethod1);
//        del2 = new SampleMethod(SampleMethod2);
//        del3 = new SampleMethod(SampleMethod3);
//        del4 = del1 + del2 + del3 - del2;
//        del4();
//        //Approcach 2

//        SampleMethod del = new SampleMethod(SampleMethod1);
//        del += SampleMethod2;
//        del += SampleMethod3;
//        del -= SampleMethod2;
//        del();

//    }

//    public static void SampleMethod1()
//    {
//        Console.WriteLine("Sample 1");
//    }
//    public static void SampleMethod2()
//    {
//        Console.WriteLine("Sample 2");
//    }
//    public static void SampleMethod3()
//    {
//        Console.WriteLine("Sample 3");
//    }
//}



////Multicast Delegate : Returned Value 
//public delegate int SampleMethod();
//public class Program
//{
//    public static void Main()
//    {
//        SampleMethod del = new SampleMethod(SampleMethod1);
//        del += SampleMethod2;
//        int DelegateReturnedValue = del();
//        Console.WriteLine("DelegateReturnedValue : " + DelegateReturnedValue);
//    }

//    public static int SampleMethod1()
//    {
//        return 1;
//    }
//    public static int SampleMethod2()
//    {
//        return 2;
//    }
//}



//Multicast Delegate : Paramter Output Value 
public delegate void SampleMethod(out int Integer);
public class Program
{
    public static void Main()
    {
        SampleMethod del = new SampleMethod(SampleMethod1);
        del += SampleMethod2;
       
        int DelegateParameterOutputValue = -1;
        del(out DelegateParameterOutputValue);
        Console.WriteLine("DelegateParameterOutputValue : " + DelegateParameterOutputValue);
    }

    public static void SampleMethod1(out int Number)
    {
        Number = 1;

    }
    public static void SampleMethod2(out int Number)
    {
        Number = 2;

    }
    
}