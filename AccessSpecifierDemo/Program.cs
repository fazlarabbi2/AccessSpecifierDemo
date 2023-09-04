using System;
using AssemblyOne;

namespace AccessSpecifierDemo
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class AnotherAssemblyClass1 : AssemblyOneClass1
    {
        public void Display4()
        {
            //You can't access the Member from the Derived Class 
            //From other Assemblies
            Console.WriteLine(Id);  //Compile Time Error
        }
    }


    public class AnotherAssemblyClass2
    {
        public void Display3()
        {
            //You can't access the Private Member from the Non-Derived Classes 
            //From other Assemblies

            AnotherAssemblyClass1 obj = new AnotherAssemblyClass1();
            Console.WriteLine(obj.Id); //Compile Time Error
        }
    }
}
