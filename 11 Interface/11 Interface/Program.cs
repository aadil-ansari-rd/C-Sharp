interface ICustomer
{
    void Print();
}
interface ICustomer1
{
    void Print1();
}
interface ICustomer2 : ICustomer ,ICustomer1  //Interface inherit multiple interfaces
{
    void Print2();
}
interface ICustomer3
{
    void Print3();
}
interface ICustomer4
{
    void Print4();
}
interface ICustomer5
{
    void Print5();
}
class Customer : ICustomer2 , ICustomer3 //Class inherit multiple Interfaces
{
    public void Print()
    {
        Console.WriteLine("Print");
    }

    public void Print1()
    {
        Console.WriteLine("Print1");

    }

    public void Print2()
    {
        Console.WriteLine("Print2");

    }

    public void Print3() //Implement by quick action
    {
        Console.WriteLine("Print3");

    }

    //void ICustomer3.Print3() //Implement by quick action
    //{
    //    Console.WriteLine("Print3");

    //}
}



class Combine : Customer, ICustomer4 ,ICustomer5 //Class inherit class along with multiple interfaces
{
    public new void Print2()
    {
        Console.WriteLine("Overridden Print2");
    }
    public void Print4()
    {
        Console.WriteLine("Print4");
    }
    public void Print5()
    {
        Console.WriteLine("Print5");
    }
}

public class Program
{
    public static void Main()
    {
        Customer customer = new Customer();
        customer.Print();
        customer.Print1();
        customer.Print2();
        customer.Print3();

        //ICustomer1 customer1 = new ICustomer1(); //Cannot create an instance of the abstract type or interface 'ICustomer1'
        Console.WriteLine("\nInterface Type with Customer Obeject are : ");
        ICustomer2 customer2 = new Customer();
        customer2.Print();
        customer2.Print1();
        customer2.Print2();
        //customer2.Print3();   //Not a member of ICustomer2

        Console.WriteLine("\nCombine Class And Interface Example : ");
        Combine combine = new Combine();
        combine.Print1();
        combine.Print2();
        combine.Print3();
        combine.Print4();
        combine.Print5();
    }
}