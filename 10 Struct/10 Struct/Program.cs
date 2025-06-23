public struct Customer
{
    private int _id;
    private string _name;

    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }

    public Customer(int id, string name)
    {
        this._id = id;
        this._name = name;
    }
    public void Print()
    {
        Console.WriteLine("Id = {0} & Name = {1}", this._id, this._name);
    }

}
public class Program
{
    public static void Main()
    {
        Customer c1 = new Customer(101,"Ram");

        Customer c2 = new Customer();
        c2.Id = 102;
        c2.Name = "Shyam";

        Customer c3 = new Customer
        {
            Id = 103,
            Name = "Mohan"
        };


        c1.Print();
        c2.Print();
        c3.Print();


    }
}