class Program
{
    static void Main()
    {
        string filePath = "example.txt";

        // ---------- Writing to the file ----------
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Hello, this is the first line.");
            writer.WriteLine("This is the second line.");
        }

        // ---------- Reading from the file ----------
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine("Read: " + line);
            }
        }
    }

    ////Example of using StreamReader and StreamWriter without using block.
    ////In this case, you must manually call .Close() to release the resources.
    //static void Main()
    //{
    //    string filePath = "example.txt";

    //    // ---------- Writing to the file ----------
    //    StreamWriter writer = new StreamWriter(filePath);
    //    writer.WriteLine("Hello without using block.");
    //    writer.WriteLine("Second line written manually.");
    //    writer.Close();  // Manually closing the writer

    //    // ---------- Reading from the file ----------
    //    StreamReader reader = new StreamReader(filePath);
    //    string line;
    //    while ((line = reader.ReadLine()) != null)
    //    {
    //        Console.WriteLine("Read: " + line);
    //    }
    //    reader.Close();  // Manually closing the reader
    //}

}
