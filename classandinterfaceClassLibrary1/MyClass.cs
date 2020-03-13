using System;

namespace classandinterfaceClassLibrary1
{
    class MyClass: Interface
    {
        public int MyInt1 = 11;
        private string myString1 = " ";

        private int myInt2 = 10;
        private string myString2 = "I am a private string";

        public static string myString3 = "I am a static string";
        public MyClass(){ }

        public MyClass(int myInt1, string myString1)
        {
            this.MyInt1 = myInt1;
            this.myString1 = myString1;
        }
         public void PrintPrivateFields()
        {
        Console.WriteLine($"Int {myInt2}, string = {myString2}");

        }
        public string myInstanceMethod()
        {
            return myString2;
        }
        public void refMethod(ref int X)
        {
            X = X + 100;
            Console.WriteLine(X);
        }
        public void ValueMethod(int x)
        {
            x = x + 222;
            Console.WriteLine(x);
        }
        public int OutMethod(int number,out int outVar)
        {
            Console.WriteLine(number);
            outVar = number + 333;
            number += number;
            return number;
        }
        public void ParameterArrayMethod(string s, params object[] args)
        {
            foreach (var ints in args)
            {
                if (ints == 0)
                {
                    Console.WriteLine("It is a 0!!");
                }
            }
        }
        public void returnDouble(int x)
        {
            return x += x;
            Console.WriteLine($"The");
        }

    }
}
