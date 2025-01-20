using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdCSharp
{
    internal class ArrayDemo
    {
        static void Main(string[] args)
        {

            int[] x = new int[3];
            x[0] = 1;
            x[1] = 2;
            x[2] = 3;
            for (int i = 0; i < 3; i++)
            {

                Console.Write(x[i] + " ");

            }
            Console.WriteLine();


            Console.WriteLine("Printing Row and columns..of two dim array...");
            Console.WriteLine();
            //  int[ , ] y = { {1,2,3 },{4,5,6 } };
            int[,] y = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int n = 0; n < 2; n++)
            {

                for (int p = 0; p < 3; p++)
                {
                    Console.Write(y[n, p] + " ");
                }

                Console.WriteLine(" ");

            }
            string[] arr1 = { "Priya", "Neha", "Nimisha" };
            for (int q = 0; q < arr1.Length; q++)
            {
                Console.WriteLine(arr1[q] + " ");

            }
            Console.WriteLine("Printing two dim array of string elements..");
            string[ , ] arr2 = { { "Priya", "Neha", "Nimisha" },{ "Sumit","Rekha","Vishakha"} };
            string[,] arr3 = new string[2, 3] { { "Priya", "Neha", "Nimisha" }, { "Sumit", "Rekha", "Vishakha" } };
            for(int r = 0;r < 2;r++)
            {
                for(int s = 0;s < 3;s++)
                {
                    Console.Write(arr2[r, s] + " ");

                }
                Console.WriteLine(" ");

            }



        }
    }

}