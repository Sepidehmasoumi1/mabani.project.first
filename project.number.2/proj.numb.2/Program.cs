using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj.numb._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("please enter a number");
            string number = Console.ReadLine();
            x = int.Parse(number);

            x *= 3;

            Console.WriteLine(x);
            Console.ReadKey();


        }
    }
}
