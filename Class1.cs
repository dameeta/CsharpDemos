using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
     class Class1
    {
        public void class1Method()
        {
            Console.WriteLine("Class1Method");
        }
    }
    class Class2 {

        public void class2Method()
        {
            Console.WriteLine("Class2Method");
        }
    }
    class Class3 { 
    public static void Main1()
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();
            class1.class1Method();
            class2.class2Method();
        }
    }
}
