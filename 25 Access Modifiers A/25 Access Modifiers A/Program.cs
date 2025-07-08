////------------------------------------------------------------------------------------------------------------------------------------
////Access Modifiers : Private 
//class Demo
//{
//    private int secret = 42;

//    public void ShowSecret()
//    {
//        Console.WriteLine("Private value: " + secret);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Demo obj = new Demo();
//        obj.ShowSecret();

//        // Console.WriteLine(obj.secret); // ❌ Error: inaccessible
//    }
//}

////------------------------------------------------------------------------------------------------------------------------------------
////Access Modifiers : Protected

//class Parent
//{
//    protected string protectedMsg = "This is protected!";
//}

//class Child : Parent
//{
//    public void ShowMessage()
//    {
//        Console.WriteLine(protectedMsg); // ✅ Allowed
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Child obj = new Child();
//        obj.ShowMessage();

//        // Console.WriteLine(obj.protectedMsg); // ❌ Error
//    }
//}



////------------------------------------------------------------------------------------------------------------------------------------
////Access Modifiers: Public

//class Sample
//{
//    public string message = "Hello from public!";
//}

//class Program
//{
//    static void Main()
//    {
//        Sample obj = new Sample();
//        Console.WriteLine(obj.message); // ✅ Direct access
//    }
//}


////------------------------------------------------------------------------------------------------------------------------------------
////------------------------------------------------------------------------------------------------------------------------------------


//Default Behaviour : When no access modifires are provided  --------------

////------------------------------------------------------------------------------------------------------------------------------------

////1.For classes(top - level): -----------------------
////internal is the default.
////Means the class is accessible within the same assembly/project, but not outside.

//class MyClass { }  // same as: internal class MyClass

////------------------------------------------------------------------------------------------------------------------------------------

////2.For class members(fields, methods, etc.) : --------------------
////private is the default.
////Means members are accessible only within the same class.

//class MyClass
//{
//    int x = 10;        // same as: private int x;
//    void Print() { }   // same as: private void Print()
//}

////------------------------------------------------------------------------------------------------------------------------------------
////Summary

//Element Type                           	 Default Access Modifier

//Class (top-level) 	                     internal
//Members (fields, methods)                private