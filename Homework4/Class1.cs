using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Class1
    {
        public Class1()
        {
            Prop1 = "Class1.Property1";
            Prop2 = "Class1.Property2";
            Prop3 = "Class1.Property3";
        }
        [Color(Color = ConsoleColor.DarkYellow)]
        public string Prop1 { get; set; }
        public string Prop2 { get; set; }
        [Color(ConsoleColor.Magenta)]
        public string Prop3 { get; set; }
    }
}
