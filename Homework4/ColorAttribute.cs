using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ColorAttribute : System.Attribute
    {
        public ColorAttribute(ConsoleColor color)
        {
            Color = color;
        }

        public ColorAttribute()
        {
            Color = Console.ForegroundColor;
        }
        public ConsoleColor Color { get; set; }
    }
}
