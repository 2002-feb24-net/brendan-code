using System;

namespace Palindrome
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
            string string1, rev;
            string1 = "racecaR";
            char[] ch = string1.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine(" " + string1 + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + string1 + " is not a Palindrome!");
            }
            Console.Read();

            string string2;
            string2 = "123abccba123";
            char[] ch = string2.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            string2.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + string2 + "is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + string2 + "is not a Palindrome!");
            }
            Console.Read();

        }
            
    }
}
