////-------------------------------------------------------------------------------------------------------------------------------

////CASE : 1
//class Progrma
//{
//    public static void Main()
//    {
//        int[] values = (int[])Enum.GetValues(typeof(Gender));
//        string[] names = (string[])Enum.GetNames(typeof(Gender));

//        foreach (int value in values)
//        {
//            Console.WriteLine(value);
//        }
//        foreach (string name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}
//public enum Gender
//{
//    Unknown ,
//    Male,
//    Female
//}

////Output
////0
////1
////2
////Unknown
////Male
////Female
///



////-------------------------------------------------------------------------------------------------------------------------------

////CASE : 2
//class Progrma
//{
//    public static void Main()
//    {
//        int[] values = (int[])Enum.GetValues(typeof(Gender));
//        string[] names = (string[])Enum.GetNames(typeof(Gender));

//        foreach (int value in values)
//        {
//            Console.WriteLine(value);
//        }
//        foreach (string name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}
//public enum Gender
//{
//    Unknown =1,
//    Male,
//    Female
//}

////Output
////1
////2
////3
////Unknown
////Male
////Female


////-------------------------------------------------------------------------------------------------------------------------------

////CASE : 3
//class Progrma
//{
//    public static void Main()
//    {
//        int[] values = (int[])Enum.GetValues(typeof(Gender));
//        string[] names = (string[])Enum.GetNames(typeof(Gender));

//        foreach (int value in values)
//        {
//            Console.WriteLine(value);
//        }
//        foreach (string name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}
//public enum Gender
//{
//    Unknown = 35,
//    Male,
//    Female
//}

////Output
////35
////36
////37
////Unknown
////Male
////Female



////-------------------------------------------------------------------------------------------------------------------------------

////CASE : 4
//class Progrma
//{
//    public static void Main()
//    {
//        int[] values = (int[])Enum.GetValues(typeof(Gender));
//        string[] names = (string[])Enum.GetNames(typeof(Gender));

//        foreach (int value in values)
//        {
//            Console.WriteLine(value);
//        }
//        foreach (string name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}
//public enum Gender
//{
//    Unknown ,
//    Male=20,
//    Female
//}

////Output
////0
////20
////21
////Unknown
////Male
////Female



////-------------------------------------------------------------------------------------------------------------------------------

////CASE : 5
//class Progrma
//{
//    public static void Main()
//    {
//        int[] values = (int[])Enum.GetValues(typeof(Gender));
//        string[] names = (string[])Enum.GetNames(typeof(Gender));

//        foreach (int value in values)
//        {
//            Console.WriteLine(value);
//        }
//        foreach (string name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}
//public enum Gender :short
//{
//    Unknown,
//    Male = 20234,
//    Female
//}

////Output
////Error : Because 'short' can't hold 20234 , because it is too big for 'short'



////-------------------------------------------------------------------------------------------------------------------------------

////CASE : 6
//class Progrma
//{
//    public static void Main()
//    {
//        //Gender gender = 3; //Cannot implicitly convert type 'int' to 'Gender'. An explicit conversion exists (are you missing a cast?)
//        Gender gender = (Gender)3;
//        Console.WriteLine(gender); //Output : 3

//        //int num = Gender.Unknown; //Cannot implicitly convert type 'Gender' to 'int'. An explicit conversion exists (are you missing a cast?)
//        int num = (int)Gender.Unknown; //Output : 0  //Because default value of 'Unknown' is 0.
//        Console.WriteLine(num);

//    }
//}
//public enum Gender
//{
//    Unknown,
//    Male,
//    Female
//}


////-------------------------------------------------------------------------------------------------------------------------------

////CASE : 7
class Progrma
{
    public static void Main()
    {
        //Season ssn = Gender.Male; //Cannot implicitly convert type 'Gender' to 'Season'. An explicit conversion exists (are you missing a cast?)
        
        Season ssn = (Season)Gender.Male;
        Console.WriteLine(ssn); //Output : Spring

        Gender gen = (Gender)Season.Summer;
        Console.WriteLine(gen); // Output : Female


        Console.WriteLine((Gender)ssn); // Output : Male
        Console.WriteLine((Season)gen); // Output : Summer
    }
}
public enum Gender
{
    Unknown,
    Male,
    Female
}
public enum Season
{
    Winter,
    Spring,
    Summer
}
