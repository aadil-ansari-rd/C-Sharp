public class ParentClass
{
    public string Name = "Ram";

    public void PrintName()
    {
        Console.WriteLine(Name + " : From Hidden Method.");
    }
}

public class ChildClass : ParentClass
{

    public new void PrintName()
    {
        base.PrintName(); //Hidden Method
        Console.WriteLine(Name + " : From Child Method.");
    }
}

public class Program
{

    public static void Main()
    {
        ChildClass cc = new ChildClass();
        cc.PrintName(); //Child class method
        Console.WriteLine("Accessing Hidden Methods :- ");
        ((ParentClass)cc).PrintName(); //By TypeCasting
        ParentClass newcc = new ChildClass();
        newcc.PrintName(); //By using Parent class reference to create child class object

    }
}