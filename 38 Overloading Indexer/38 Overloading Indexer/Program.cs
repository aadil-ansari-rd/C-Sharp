// Example 1 :  Indexer Overloading


class Sample
{
    private int[] numbers = { 10, 20, 30 };
    private string[] words = { "one", "two", "three" };

    // Integer indexer
    public int this[int index]
    {
        get { return numbers[index]; }
    }

    // String indexer
    public string this[string key]
    {
        get
        {
            return key switch
            {
                "first" => words[0],
                "second" => words[1],
                "third" => words[2],
                _ => "Invalid"
            };
        }
    }
}

class Program
{
    static void Main()
    {
        Sample obj = new Sample();

        Console.WriteLine(obj[1]);       // Output: 20
        Console.WriteLine(obj["second"]); // Output: two
    }
}




//-------------------------------------------------------------------------------------------------

//// Example 2 :  Indexer Overloading : Different Parameters Types


//using System;

//class DataStore
//{
//    private string[] names = { "Aadil", "Rohan", "Simran" };
//    private int[] ages = { 18, 20, 22 };

//    // Integer indexer
//    public string this[int index]
//    {
//        get { return names[index]; }
//    }

//    // String indexer
//    public int this[string name]
//    {
//        get
//        {
//            for (int i = 0; i < names.Length; i++)
//            {
//                if (names[i] == name)
//                    return ages[i];
//            }
//            return -1; // not found
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        DataStore ds = new DataStore();

//        Console.WriteLine(ds[0]);        // Output: Aadil
//        Console.WriteLine(ds["Simran"]); // Output: 22
//    }
//}



//--------------------------------------------------------------------------------------------
//// Example 2 :  Indexer Overloading : Different Number Of Parameters


//using System;

//class Matrix
//{
//    private int[,] matrix = new int[3, 3];

//    // Single index (1D access)
//    public int this[int index]
//    {
//        get { return matrix[index, index]; }
//        set { matrix[index, index] = value; }
//    }

//    // Double index (2D access)
//    public int this[int row, int col]
//    {
//        get { return matrix[row, col]; }
//        set { matrix[row, col] = value; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Matrix m = new Matrix();

//        // Using single indexer
//        m[1] = 10;
//        Console.WriteLine(m[1]);   // Output: 10 (matrix[1,1])

//        // Using double indexer
//        m[2, 0] = 25;
//        Console.WriteLine(m[2, 0]); // Output: 25
//    }
//}
