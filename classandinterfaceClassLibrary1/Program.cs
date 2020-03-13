using System;
using System.Collections.Generic;
using System.Text;

namespace classandinterfaceClassLibrary1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello WOrld");

            MyClass myClass1 = new MyClass();
            Console.WriteLine(myClass1.myInt1);

            MyClass myClass2 = new MyClass(12, "This is a new stirng");
            Console.WriteLine("This is the int => {0}\n This is the string=>")

            myClass2.PrintPrivateFields();

            Console.WriteLine(MyClass.myString3);
            string privatestring = myClass2.myInstanceMethod;
            Console.WriteLine(privatestring2);
            Console.WriteLine("test" + MyClass.myString3);

            int y = 11;
            Console.WriteLine($"ref variable y == {y}");
            myClass1.refMethod(ref y);
            Console.WriteLine($"ref variable y == {y}");

            int z = 22;
            Console.WriteLine($"Value variable y == {z}");
            myClass1.ValueMethod(z);
            Console.WriteLine($"Value variable y == {z}");

            //int outV;
            int outReturn = myClass1.OutMethod(33, out int outVar);
            Console.WriteLine("the outvariable is {outV}");
            Console.WriteLine($"the return of outMethod is {outReturn}");

            Console.WriteLine("Param array below");
            Console.WriteLine("test", 1, 2, 3, 4, 5, 6, 7, 8, 0);

            int returnDouble = myClass1.returnDouble(500);
            Console.WriteLine(returnOfDouble);
        } 
    }
}
