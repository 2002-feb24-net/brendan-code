using System;

namespace C_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello my name is Brendan";
            System.Console.WriteLine(message);  

            int num1 = 5;
            num1 = 7;
            int num2 = 9;
            int num3 = num1 + num2;

            System.Console.WriteLine("Enter a double");
            double myDouble = Convert.ToDouble (System.Console.ReadLine());
            bool num = Check(num1, num2);
            System.Console.WriteLine(num);
        

            string[] name = {"Harold, Tyler, Paul, Tod, Jon, Kyran"};
            for (int i = 0; i < name.Length; i++)
            {
                System.Console.WriteLine(name[i]);
            }
            foreach (var names in name)
            {
                System.Console.WriteLine(names);
            }
            
        }
        private static void Greeting(string message)
        {
           message = "Good bye";
           string message1 = "see you tomorrow";
           string message2 = message + message1;
            System.Console.WriteLine(message2);
        }
        private static bool Check(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Make a switch stament with the variable of the user niput(it has to be a new variable) and it
        //output anything and must be at least 5 casees
