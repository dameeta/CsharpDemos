using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BasicDemo
{
    internal class MethodDemos
    {
        public void method1()
        {
            Console.WriteLine("Inside void method1()");
        
        }
        public double method2(float a,float b,double c) {
            a=float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c=double.Parse(Console.ReadLine());
            double si = (a*b*c/100);
            return si;

        }
        public static void Main2(string[] args)
        {
            Console.WriteLine("Printing values from methods");
            MethodDemos methoddemos=new MethodDemos();
            methoddemos.method1();
            Console.WriteLine("Inside method2");

            Console.WriteLine(methoddemos.method2(3,4,5));

        }
    }
}
