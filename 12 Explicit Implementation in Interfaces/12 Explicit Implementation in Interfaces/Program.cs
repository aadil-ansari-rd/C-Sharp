interface IC1
{
    void Print();
}
interface IC2
{
    void Print();
}
class Program : IC1, IC2
{
    public void Print() //Default Implementation : Only access by class type reference, not by interface type reference
    {
        Console.WriteLine("Default Print");
    }
    void IC1.Print() //Particular Implementation : Only access by interface type reference, not by class type reference
    {
        Console.WriteLine("Secific IC1");
    }
    void IC2.Print()
    {
        Console.WriteLine("Secific IC2");
    }
    public static void Main()
    {
        Program program = new Program();
        program.Print();
        ((IC1)program).Print();
        ((IC2)program).Print();


        IC1 c1 = new Program();
        c1.Print();

        IC2 c2 = new Program();
        c2.Print();

    }
}


//----------------------------------------------------------------------------------



//interface IC1
//{
//    void Print();
//}
//interface IC2
//{
//    void Print();
//}
//class Program : IC1, IC2
//{
//    public void Print()
//    {
//        Console.WriteLine("Default Print");
//    }
//    public static void Main()
//    {
//        Program program = new Program();
//        program.Print();
//        ((IC1)program).Print();
//        ((IC2)program).Print();


//        IC1 c1 = new Program(); 
//        c1.Print();

//        IC2 c2 = new Program();
//        c2.Print();

//    }
//}