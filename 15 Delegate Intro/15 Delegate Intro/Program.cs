using System;
public  delegate void HelloDelegate(string s);
class Program
{
    public static void Main()
    {
        HelloDelegate del = new HelloDelegate(Hello);
        del("Hello from delegate.");

    }
    public static void Hello(string s)
    {
        Console.WriteLine(s);
    }
}