//---------------------------------------------------------------------------------------------------------------------------

////Code Without Enums

////Gender   : Code 
////Unknown  : 0
////Male     : 1
////Female   : 2

//class Customer
//{
//    public string Name { get; set; }
//    public int Gender { get; set; }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Customer[] customers = new Customer[3];
//        customers[0] = new Customer
//        {
//            Name = "Max",
//            Gender = 0
//        };
//        customers[1] = new Customer
//        {
//            Name = "Joe",
//            Gender = 1
//        };
//        customers[2] = new Customer
//        {
//            Name = "Neena",
//            Gender = 2
//        };
//        foreach (Customer customer in customers)
//        {
//            Console.WriteLine("Name   : " + customer.Name);
//            Console.WriteLine("Gender : " + getGender(customer.Gender));
//            Console.WriteLine();
//        }
//    }
//    public static string getGender(int gender)
//    {
//        switch (gender)
//        {
//            case 0:
//                return "Unknown";
//            case 1:
//                return "Male";
//            case 2:
//                return "Female";
//            default:
//                return "Not valid";
//        }
//    }
//}

//---------------------------------------------------------------------------------------------------------------------------


//Code Without Enums

public enum Gender
{
    Unknown,
    Male,
    Female
}
class Customer
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
}

class Program
{
    public static void Main(string[] args)
    {
        Customer[] customers = new Customer[3];
        customers[0] = new Customer
        {
            Name = "Max",
            Gender = Gender.Unknown
        };
        customers[1] = new Customer
        {
            Name = "Joe",
            Gender = Gender.Male
        };
        customers[2] = new Customer
        {
            Name = "Neena",
            Gender = Gender.Female
        };
        foreach (Customer customer in customers)
        {
            Console.WriteLine("Name   : " + customer.Name);
            Console.WriteLine("Gender : " + customer.Gender);
            Console.WriteLine("Gender {0} Confirmed", getGender(customer.Gender));
            Console.WriteLine();

        }
    }
    public static string getGender(Gender gender)
    {
        switch (gender)
        {
            case Gender.Unknown:
                return "Others";
            case Gender.Male:
                return "Male";
            case Gender.Female:
                return "Female";
            default:
                return "Not valid";
        }
    }
}

//---------------------------------------------------------------------------------------------------------------------------


