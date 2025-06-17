public class ParentClass
{
    public string Name = "Ram";

    public ParentClass()
    {
        Console.WriteLine("Parent class non parameterised constructr called");
    }
    public ParentClass(string message)
    {
        Console.WriteLine("Parent class parameterised constructr called with message : " + message);
    }

    public void PrintName()
    {
        Console.WriteLine(Name + " : From Parent Method.");
    }
}

public class ChildClass : ParentClass
{
    public ChildClass() : base("Everything is good...") //calling parent constructor
    {
        Console.WriteLine("Child class constructor called.");

    }
    public new void PrintName() 
    {
        Console.WriteLine(Name + " : From Child Method.");
    }
}

public class Program
{
    
    public static void Main()
    {
        //ParentClass pc = new ParentClass();
        //pc.PrintName();
        ChildClass cc = new ChildClass();
        cc.PrintName();
    }
}