using System;

namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        private int Id;
        public void Display()
        {
            //Private Member Accessible with the Containing Type only
            //Where they are created, they are available only withing that type
            Console.WriteLine(Id);
        }
    }

    public class AssemblyOneClass2 : AssemblyOneClass1
    {
        public void Display2()
        {
            //You cannot access the Private Member from the Derived Class
            //Withing the same Assembly
            Console.WriteLine(Id); //Compile Time Error
        }
    }

    public class AssemblyOneClass3
    {
        public void Display3()
        {
            //You can't access the Private Member from the Non-Derived Classes
            //Within the same Assembly

            AssemblyOneClass1 obj = new AssemblyOneClass1();
            Console.WriteLine(obj.Id);
        }
    }
}
