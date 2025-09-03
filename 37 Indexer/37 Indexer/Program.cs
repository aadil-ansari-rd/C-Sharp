
// Exmaple : Simple Integer Indexer

class Student
{
    private string[] names = new string[5];

    // Indexer declaration
    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        // Using indexer like an array
        s[0] = "Aadil";
        s[1] = "Rohan";
        s[2] = "Simran";

        Console.WriteLine(s[0]); // Output: Aadil
        Console.WriteLine(s[1]); // Output: Rohan
    }
}


//-----------------------------------------------------------------------------------------
//// Exmaple : String Indexer
//using System;
//using System.Collections.Generic;

//class PhoneBook
//{
//    private Dictionary<string, string> contacts = new Dictionary<string, string>();

//    // Indexer with string key
//    public string this[string name]
//    {
//        get { return contacts.ContainsKey(name) ? contacts[name] : "Not Found"; }
//        set { contacts[name] = value; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        PhoneBook pb = new PhoneBook();

//        pb["Aadil"] = "1234567890";
//        pb["Rohan"] = "9876543210";

//        Console.WriteLine(pb["Aadil"]);  // Output: 1234567890
//        Console.WriteLine(pb["Simran"]); // Output: Not Found
//    }
//}