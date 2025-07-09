using AssemblyOne;
using System;
namespace AssemblyTwo
{
    //public class AssemblyTwoClass1
    //{
    //    public void Coo()
    //    {
    //        //AssemblyOneClass1 obj = new AssemblyOneClass1();
    //        //obj.ID = 50; // 'AssemblyOneClass1.ID' is inaccessible due to its protection level
    //        AssemblyOneClass2 obj = new AssemblyOneClass2();
    //        obj.SampleMethod();
    //    }
    //}
    //----------------------------------------------------------------------------------------------------------
    //public class AssemblyTwoClass2 : AssemblyOneClass1
    //{
    //    public void Doo()
    //    {
    //        //Console.WriteLine(ID); // 'AssemblyOneClass1.ID' is inaccessible due to its protection level
    //    }
    //}
    //----------------------------------------------------------------------------------------------------------

    //public class AssemblyTwoClass3 : AssemblyOneClass2
    //{
    //    public void Foo()
    //    {
    //        SampleMethod();
    //    }
    //}
    //----------------------------------------------------------------------------------------------------------

    public class AssemblyTwoClass4 : AssemblyOneClass3
    {
        public void Hoo()
        {
            base.ID = 50;
            this.ID = 60;
            Console.WriteLine(ID); // The name 'ID' does not exist in the current context.
        }
    }
}
