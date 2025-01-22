using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExamples
{
    internal class LinkedListExample
    {
        static void Main(string[] args)
        {

            var cities = new LinkedList<string>();
            cities.AddLast("Kochi");
            cities.AddLast("Mumbai");
            cities.AddLast("Pune");
            cities.AddLast("Telangana");
            cities.AddLast("Delhi");
            foreach (var i in cities)
            {
                Console.WriteLine(i);

            }
            LinkedListNode<string> node = cities.Find("Pune");
            cities.AddBefore(node, "Kolkatta");
            foreach (var i in cities)
            {
                Console.WriteLine(i);

            }
            cities.

        }


        
    }
    
}