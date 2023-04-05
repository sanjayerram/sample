using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPracice
{
    public class ReverseString
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a string");
            string str = Console.ReadLine();
            str = str.ToLower();
            string revstring = "";

            for (int i=str.Length-1;i>=0;i--)
            {
                revstring = revstring + str[i];
            }
            Console.WriteLine(revstring);

            if (revstring.Equals(str))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.Write("Not Palindrome");
            }
            Console.ReadLine();
        }
    }
}
