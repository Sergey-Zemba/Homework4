using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();
            Class3 c3 = new Class3();
            c3.Prop1 = "nif";
            c3.Prop2 = "nuf";
            c3.Prop3 = "noof";
            Print print = new Print();
            print.ColorPrint(c3);
        }
    }
}
