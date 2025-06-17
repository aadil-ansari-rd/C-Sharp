public class Customer
{
    string firstName;
    string lastName;

    public Customer() : this("Aadil", "Ansari")
    {

    }

    public Customer(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    public void PrintName()
    {
        Console.WriteLine("Full name = {0} ", firstName + " " + lastName);
    }
    ~Customer() { }
}
public class Program
{
    public static void Main()
    {
        Customer C1 = new Customer("Aadil", "Ansari");
        C1.PrintName();
        Customer C2 = new Customer();
        C2.PrintName();
    }
}