using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPracice
{
    public class StatifFields
    {
        int var1;
        static int var2;

        public void Read()
        {
            Console.WriteLine("Ener a value for var1");
            var1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a value for var2");
            var2 = int.Parse(Console.ReadLine());

        }

        public void Print()
        {
            Console.WriteLine("first variable value is {0} \t second variable value is {1}", var1, var2);

        }
        public static void Main()
        {
            StatifFields obj1 = new StatifFields();
            StatifFields obj2 = new StatifFields();
            StatifFields obj3 = new StatifFields();

            obj1.Read();
            obj2.Read();
            obj3.Read();

            obj1.Print();
            obj2.Print();
            obj3.Print();
            Console.ReadLine();


        }
    }
}
