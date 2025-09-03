using System;

namespace _36_Partial_Method
{
    // Declaring partial class (part 1)
    public partial class SamplePartialClass
    {
        // Partial method declaration (implementation will be in another file)
        partial void DeclarationImplementationNotInSameFile();

        // Partial method declaration + implementation in SAME file
        partial void DeclarationImplementationInSameFile();
        partial void DeclarationImplementationInSameFile()
        {
            Console.WriteLine("DeclarationImplementationInSameFile() Method Invoked.");
        }

        // Public method to call partial methods
        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod() Invoked.");

            // Calls method implemented in the same file
            DeclarationImplementationInSameFile();

            // Calls method implemented in another file
            DeclarationImplementationNotInSameFile();
        }
    }
}
