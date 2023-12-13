using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    internal class MethodOverloading
    {
        public int findArea(int l,int b)
        {
            return l * b;
        }
        public double findArea(double radius) {
            return 3.14 * radius * radius;
        }

        public double findArea(float b,float h) {

            return 0.5 * (b * h);

        }
        public double findArea(float side)
        { 
        
        return side* side;
        }

        public static void Main(string[] args)
        {

MethodOverloading methodOverloading = new MethodOverloading();
            Console.WriteLine("Area of Rectangle:"+ methodOverloading.findArea(4, 5));
            Console.WriteLine("Area of Circle: "+ methodOverloading.findArea(3.4));
            Console.WriteLine("Area of Triangle:"+ methodOverloading.findArea(2.3));
            Console.WriteLine("Area of Square:" + methodOverloading.findArea(5.5));


        }
    }
}
