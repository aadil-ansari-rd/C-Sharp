class Program
{

    //Always use if (ex.InnerException != null) before accessing ex.InnerException.Message.
    //It makes the code safe and null-proof.
    static void Main()
    {
        try
        {
            try
            {
                // This will throw a DivideByZeroException
                int x = 5;
                int y = 0;
                int result = x / y;
            }
            catch (DivideByZeroException ex)
            {
                // Wrapping the original exception with a new one
                throw new Exception("An error occurred during calculation.", ex);
            }
        }
        catch (Exception outerEx)
        {
            Console.WriteLine("Outer Exception: " + outerEx.Message);

            // ✅ Always check if InnerException is not null
            if (outerEx.InnerException != null)
            {
                Console.WriteLine("Inner Exception: " + outerEx.InnerException.Message);
            }
            else
            {
                Console.WriteLine("No inner exception found.");
            }
        }
    }

        ////Example : Without checking inner Exception is null or not 
        //static void Main()
        //{
        //    try
        //    {
        //        try
        //        {
        //            // This will cause a FormatException
        //            int number = int.Parse("not_a_number");
        //        }
        //        catch (FormatException ex)
        //        {
        //            // Wrap the FormatException inside a new Exception
        //            throw new Exception("Parsing failed in inner block.", ex);
        //        }
        //    }
        //    catch (Exception outerEx)
        //    {
        //        Console.WriteLine("Outer Exception Message: " + outerEx.Message);
        //        Console.WriteLine("Inner Exception Message: " + outerEx.InnerException?.Message);
        //    }
        //}

    }
