//A static constructor must be parameterless
//access modifiers are not allowed on static constructors
//Keyword 'this' is not valid in a static property, static method,staic constructor, or static field initializer
//An object reference is required for the non-static field, method, or property 'Circle.radius'
//Static method inside a class can not use instance variables.
//Static method cannot be accessed with an instance reference; it should be   ClassName.MethodName
class Circle
{
    //static float pi = 3.14f; //Valid

    static float pi;

    float radius;
    static Circle()
    {
        // pi =  3.14f; //valid
        Circle.pi = 3.14f; //valid
        Console.WriteLine("Pi : " + pi);
    }

    public Circle(float radius)
    {
        this.radius = radius;
    }
    public void PrintArea()
    {
        double area = (double)Circle.pi * this.radius * this.radius;
        Console.WriteLine("Area is : " + area);
    }
    public static void StaticPrintArea()
    {
        Console.WriteLine("I am static PrintArea method of Circle class.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Circle C1 = new Circle(20);
        C1.PrintArea();
        Circle.StaticPrintArea();
    }
}