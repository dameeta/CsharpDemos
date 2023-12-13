/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {

    
        Console.WriteLine("Enter how many row want to add");
        int row=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter how many columns to add");
        int col=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of elements you want to add for rows and columns");
        int [,] twodim = new int[row,col];
        for (int i = 0; i < row; i++)
        { 
        for (int j = 0; j < col; j++)
            {
        twodim[i,j]=Convert.ToInt32(Console.ReadLine());

            }
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(twodim[i,j]+ " \t");

            }
            Console.WriteLine(" ");

        }

    }
  }

