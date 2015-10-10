using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Class3
    {
        public Class3()
        {
            Prop1 = "Class3.Property1";
            Prop2 = "Class3.Property2";
            Prop3 = "Class3.Property3";
        }
        [Color]
        public string Prop1 { get; set; }
        [Color(Color = ConsoleColor.Blue)]
        public string Prop2 { get; set; }
        [Color(ConsoleColor.DarkGreen)]
        public string Prop3 { get; set; }
    }
}
