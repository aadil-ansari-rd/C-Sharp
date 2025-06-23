public class Parent
{
    public virtual void Print()
    {
        Console.WriteLine("Parent");
    }
}
public class Child1 : Parent
{
    public override void Print()
    {
        Console.WriteLine("Child1");
    }
}
public class Child2 : Parent
{
    public new void Print()
    {
        Console.WriteLine("Child2");
    }
}

public class Child3 : Parent
{
    public  void Print()
    {
        Console.WriteLine("Child3");
    }
}

public class Child4 : Parent
{
    
}

public class Program
{
    public static void Main()
    {
        Parent[] vari = new Parent[5];
        vari[0] = new Parent();
        vari[1] = new Child1();
        vari[2] = new Child2();
        vari[3] = new Child3();
        vari[4] = new Child4();
        vari[0].Print();
        vari[1].Print();
        vari[2].Print();
        vari[3].Print();
        vari[4].Print();
        

    }
    

}