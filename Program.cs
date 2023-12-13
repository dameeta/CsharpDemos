using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    internal class Program
    {
        static int x;
       static int y;
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + y);

        }
    }
}
