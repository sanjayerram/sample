using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CsharpPracice
{
    public delegate void HelloFunctionDelegate(string str);
    public class DelegateDemo
    {
        public static void Main()
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from delegate");
            Console.ReadLine();
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
        //delegate is a type safe function pointer. 
        //It holds a reference to a function.
        //signature of the function must match the signature of the delegate.Otherwise compile time error will rises.
        // This is the reason delegates are called as type safe function pointers.
        //A delegate is similar to a class. 
        //you can create an instance of delegate and pass the name of function as a parameter to the delegate constructor.
        //And to this function delegate will point to.
        //Delegate syntax is similar to that of function with a delegate key word.
   
    }
}
