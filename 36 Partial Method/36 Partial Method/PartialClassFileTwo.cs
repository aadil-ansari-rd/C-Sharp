using System;

namespace _36_Partial_Method
{
    // Declaring partial class (part 2)
    public partial class SamplePartialClass
    {
        // Implementation of method declared in file 1
        partial void DeclarationImplementationNotInSameFile()
        {
            Console.WriteLine("DeclarationImplementationNotInSameFile() Method Invoked.");
        }
    }
}
