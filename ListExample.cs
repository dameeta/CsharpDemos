using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExamples
{
    internal class ListExample
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("List Example..");
            List<int> list = new List<int>();
           /* for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            foreach (int i in list)
            {
                {
                    Console.Write(i + " ");
                }
            }*/
           // list.Capacity = 4;
            //Console.WriteLine(list.Capacity + " ");
            list.Add(33);
            list.Add(21);
            list.Add(67);
            list.Add(18);
            list.Add(22);
            list.Add(7);
            //Console.WriteLine(list.Capacity + " ");
            foreach (int i in list)
            {
                {
                    Console.WriteLine(i + " ");
                }
            }
            list.Remove(22);
            list.RemoveAt(3);

            Console.WriteLine( "after removing 0th index element ");
            foreach (int j in list)
            {
                {
                    Console.WriteLine(j + " ");
                }
            }
            //Console.WriteLine(list.Capacity + " " );
            Console.WriteLine("*********** " );
            foreach (int i in list)
            {
                {
                    Console.WriteLine(i + " ");
                }
            }




        }
    }
}