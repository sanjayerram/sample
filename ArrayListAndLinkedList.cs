using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CsharpPracice
{
    class ArrayListAndLinkedList
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> al = new List<string>();
                al.Add("Tina");
                al.Add("sanjay");

                foreach (var item in al)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
            finally
            {
                

            }

//1) ArrayList internally uses a dynamic array to store the elements.
//2) Manipulation with ArrayList is slow because it internally uses an array.If any element is removed from the array, all the other elements are shifted in memory.
//3) An ArrayList class can act as a list only because it implements List only.
//4) ArrayList is better for storing and accessing data.
//5) The memory location for the elements of an ArrayList is contiguous.
//6) Generally, when an ArrayList is initialized, a default capacity of 10 is assigned to the ArrayList.
//7) To be precise, an ArrayList is a resizable array.
        }

    }


}
