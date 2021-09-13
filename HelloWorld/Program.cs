using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!"); // display text
            Console.WriteLine(""); // makes a space
            Console.WriteLine("This is my Github test submission."); // more text next line under
            Console.WriteLine("");
            Console.WriteLine("Press E to exit..."); 
            while (Console.ReadKey().Key != ConsoleKey.E); // user MUST press E in order to continue, in this case exit
        }
    }
}
