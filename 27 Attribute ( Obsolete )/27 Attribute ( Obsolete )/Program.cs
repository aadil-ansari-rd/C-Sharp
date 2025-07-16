class ObsoleteExample
{
    // 1. No message
    [Obsolete]
    public void Method1()
    {
        Console.WriteLine("Method1: No message, only warning.");
    }

    // 2. With custom message
    [Obsolete("Method2 is obsolete, use MethodNew() instead.")]
    public void Method2()
    {
        Console.WriteLine("Method2: Warning with message.");
    }

    // 3. With custom message + warning (false)
    [Obsolete("Method3 is outdated, please use MethodNew().", false)]
    public void Method3()
    {
        Console.WriteLine("Method3: Warning with message (false).");
    }

    // 4. With custom message + error (true)
    [Obsolete("Method4 is removed! Do not use!", true)]
    public void Method4()
    {
        Console.WriteLine("Method4: This should cause an error.");
    }

    // Recommended method
    public void MethodNew()
    {
        Console.WriteLine("MethodNew: This is the recommended method.");
    }

    static void Main()
    {
        ObsoleteExample example = new ObsoleteExample();
        example.Method1();      // Warning: No message
        example.Method2();      // Warning: Custom message
        example.Method3();      // Warning: Message, false
        // example.Method4();   // Uncommenting this line causes compile-time error
        example.MethodNew();    // Correct usage
    }
}
