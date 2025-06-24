public abstract class Abs
{
    public abstract void Print();
}
interface IC1
{
     void Print1();
}
interface IC2
{
    void Print2();
}

//Abstract class inherit an abstract class along with Interface
public abstract class Abs3 : Abs, IC1 
{
    public void Print1()
    {
        Console.WriteLine("Print1 Interface");
    }
    public  void Print3()
    {
        Console.WriteLine("Print3");

    }
    public abstract void Print4();
    
}

//Normal class inherit an abstract class along with Interface

public class Main : Abs3 ,IC2
{
    public override void Print()
    {
        Console.WriteLine("Print");
    }
    public override void Print4()
    {
        Console.WriteLine("Print4");
    }
    public void Print2()
    {
        Console.WriteLine("Print2 Interface");
    }
}

public class Program
{
    public static void Main()
    {
        Main mn = new Main();
        mn.Print(); //Print
        mn.Print1 (); //Print1 Interface
        mn.Print2(); //Print2 Interface
        mn.Print3(); //Print3
        mn.Print4(); //Print4
                    
        ((Abs)mn).Print(); //Print
        ((IC1)mn).Print1 (); //Print1 Interface
        ((IC2)mn).Print2(); //Print2 Interface
        ((Abs3)mn).Print3(); //Print3
        ((Abs3)mn).Print4(); //Print4

    }
}