using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CsharpPracice
{
    public class stringreplaceDemo
    {
        public static void Main()
        {
            string str = "Selenium tutorial includes all topics of Selenium such as Features,Selenium vs QTP";
            Console.WriteLine(str);
            string[] strArray;
            strArray = str.Split(' ');
            for(int i=0;i<strArray.Length;i++)
            {
                Console.WriteLine(strArray[i]);

               

            }

            for (int j = 0; j < strArray.Length; j++)
            {
                if (strArray[j].Contains(","))
                {
                    strArray[j].Replace(",", " ");
                    
                    Console.WriteLine(strArray[j]);
                }
                //Console.ReadLine();
            }
              Console.ReadLine();
        }
    }
}
