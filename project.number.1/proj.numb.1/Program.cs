using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj.numb._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("please enter your name");
            name = Console.ReadLine();

            Console.WriteLine("hello" + name);
            Console.WriteLine("press any key to exit...");

            Console.ReadKey();
        }
    }
}
