using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPracice
{
    class Smallest
    {
        public static void Main()
        {

            int[] num = { 12, 1, 5, 3 };
            int len = num.Length;
            int small = num[0];
            int i = 0;
            while (i < len)
            {
                if (num[i]<small)
                {
                    small = num[i];
                }
                i = i + 1;
            }
            Console.WriteLine(small);
            Console.ReadLine();
        }
    }
}
