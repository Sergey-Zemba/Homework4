using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Class2
    {
        public Class2()
        {
            Prop1 = "Class2.Property1";
            Prop2 = "Class2.Property2";
            Prop3 = "Class2.Property3";
        }
        public string Prop1 { get; set; }
        [Color(ConsoleColor.Black)]
        public string Prop2 { get; set; }
        public string Prop3 { get; set; }
    }
}
