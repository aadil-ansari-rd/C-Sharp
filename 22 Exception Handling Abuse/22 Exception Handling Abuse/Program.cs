using System.Net.NetworkInformation;

class Program
{
    public static void Main()
    {

        ////Example 1: Using Parse() with Multiple catch Blocks

        //try
        //{
        //    Console.WriteLine("Enter the Numerator");
        //    int Numerator = Int32.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter the Denominator");
        //    int Denominator = Int32.Parse(Console.ReadLine());
        //    int Result = Numerator / Denominator;
        //    Console.WriteLine("Result : {0}", Result);
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine("Please enter a valid numerber.");
        //}
        //catch (OverflowException ex)
        //{
        //    Console.WriteLine("Only number between {0} & {1} are allowed.", Int32.MinValue, Int32.MaxValue);
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Denominator cant be zero.");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}



        //Example 2: Using TryParse() for Safe Conversion with Manual Checks

        try
        {
            Console.WriteLine("Enter the Numerator");
            int Numerator;
            bool IsNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);
            if (IsNumeratorConversionSuccessful)
            {
                Console.WriteLine("Enter the Denominator");
                int Denominator;
                bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);
                Console.WriteLine(Denominator);
                if (IsDenominatorConversionSuccessful && Denominator != 0)
                {
                    int Result = Numerator / Denominator;
                    Console.WriteLine("Result : {0}", Result);
                }
                else
                {
                    if (Denominator == 0)
                    {
                        Console.WriteLine("Denominator cant be zero.");
                    }
                    else
                    {
                        Console.WriteLine("Denominator should be valid number between {0} & {1} .", Int32.MinValue, Int32.MaxValue);
                    }
                }
            }
            else
            {
                Console.WriteLine("Numerator should be valid number between {0} & {1} .", Int32.MinValue, Int32.MaxValue);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}