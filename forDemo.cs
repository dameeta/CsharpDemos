using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo

{ 
    internal class forDemo
    {
        //for,foreach,while do while switch case break continue
        static void Main1(string[] args)
        {
            Console.WriteLine("Printing 5's table..");
            int limit = 11;
            do
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("5*{0}={1}", i, 5 * i);
                }
            } while (limit<10);
        }
        }
    }

