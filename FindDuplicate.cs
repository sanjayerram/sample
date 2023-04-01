using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPracice
{
    public class FindDuplicate
    {
        public static void Main()
        {
            int[] array = new int[] { 4, 8, 4, 1, 1, 4, 8 };
            int numDups = 0, prevIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool foundDup = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        foundDup = true;
                        numDups++; // Increment means Count for Duplicate found in array.
                        break;
                    }
                }

                if (foundDup == false)
                {
                    array[prevIndex] = array[i];
                    prevIndex++;
                }
            }

            // Just Duplicate records replce by zero.
            for (int k = 1; k <= numDups; k++)
            {
                array[array.Length - k] = '\0';
            }


            Console.WriteLine("Console program for Remove duplicates from array.");
            Console.Read();
            Console.ReadLine();
        }
    }
}
