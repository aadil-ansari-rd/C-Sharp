class Program
{
    public static void Main()
    {
        string filePath = "example.txt";
        // ---------- Writing to the file ----------
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Hello, this is the first line.");
            writer.WriteLine("This is the second line.");
        }



        StreamReader streamReader = null;
        try
        {
            streamReader = new StreamReader(filePath);
            Console.WriteLine(streamReader.ReadToEnd());
        }
        catch(FileNotFoundException ex)
        {
            //log the details
            Console.WriteLine("Please check if the file {0} exists " , ex.FileName);
        }
        finally
        {
            if(streamReader != null)
            {
                streamReader.Close();
            }
            Console.WriteLine("Finally Block");
        }

    }
}