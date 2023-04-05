using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPracice
{
    public class PrintTill100
    {
        public static int i = 0;
        public static void Main()
        {

            i = i + 1;
            if (i <= 100)
            {
                Console.WriteLine(i);
                Main();
            }
            else
            {
            Console.ReadLine();
            }
        }
    }
}
