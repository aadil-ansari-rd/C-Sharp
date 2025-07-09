using System;
namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        internal int ID = 101;
    }
    //----------------------------------------------------------------------------------------------------------

    public class AssemblyOneClass2
    {
        public void SampleMethod()
        {
            AssemblyOneClass1 obj = new AssemblyOneClass1();
            Console.WriteLine(obj.ID);
        }
        
    }
    //----------------------------------------------------------------------------------------------------------

    public class AssemblyOneClass3
    {
        protected internal int ID = 101;
    }
}
