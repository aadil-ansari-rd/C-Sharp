//Multiple Ineritence Using  Interfaces

interface IA
{
    void AMethod();
}
class A : IA
{
    public void AMethod()
    {
        Console.WriteLine("A");
    }
}
interface IB
{
    void BMethod();
}
class B : IB
{
    public void BMethod()
    {
        Console.WriteLine("B");
    }
}
class AB : IA , IB
{
    A a = new A();
    B b = new B();
    public void AMethod()
    {
        a.AMethod();
    }
    public void BMethod()
    {
        b.BMethod();
    }
}
class Program
{
    public static void Main()
    {
        AB ab = new AB();
        ab.AMethod();
        ab.BMethod();
    }
}

































//Multiple Ineritence Using classes

//class A
//{
//    public virtual void Print()
//    {
//        Console.WriteLine("Class A implementation.");
//    }
//}
//class B:  A {
//    public override void Print()
//    {
//        Console.WriteLine("Class B Overriding Print() Method");
//    }
//}
//class C: A
//{
//    public override void Print()
//    {
//        Console.WriteLine("Class C Overriding Print() Method");
//    }
//}
//class D : B,C
//{

//}

//class Program
//{
//    public static void Main()
//    {
//        D d = new D();
//        d.Print();
//    }
//}