using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExamples
{
    internal class QueueExample
    {
        static void Main(string[] args)
        {
           
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("a");
            queue.Enqueue("b");
                queue.Enqueue("c");
            queue.Enqueue("d");
            queue.Enqueue("e");
            queue.Enqueue("f");
            Console.WriteLine(queue.Count);
            for (int i = 0; i < 6; i++)
            {
                {
                    Console.WriteLine(queue.Dequeue());

                }


            }
        }
    }
}
