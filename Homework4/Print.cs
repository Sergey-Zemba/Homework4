using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Print
    {
        public void ColorPrint(object obj)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Type type = obj.GetType();
            PropertyInfo[] pi = type.GetProperties();
            foreach (PropertyInfo propertyInfo in pi)
            {
                object[] objects = propertyInfo.GetCustomAttributes(false);
                foreach (object o in objects)
                {
                    if (o is ColorAttribute)
                    {
                        Console.ForegroundColor = (o as ColorAttribute).Color;
                        continue;
                    }
                }
                Console.WriteLine(type.Name + " " + propertyInfo.Name);
                Console.ForegroundColor = defaultColor;
            }
        }
    }
}
