﻿using ClassLibraryVisitorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitorPattern
{
    public class ConsoleVisitor : IVisitor
    {
        public void Visit(Circle _circle)
        {
            Console.WriteLine($"{_circle.GetType()}");
            Console.WriteLine($"Position : ({_circle.X};{_circle.Y})");
            Console.WriteLine($"Radius   : {_circle.Radius}");
        }

        public void Visit(Rectangle _rectangle)
        {
            Console.WriteLine($"{_rectangle.GetType()}");
            Console.WriteLine($"Position : ({_rectangle.X};{_rectangle.Y})");
            Console.WriteLine($"Length   : {_rectangle.Length}");
            Console.WriteLine($"Width    : {_rectangle.Width}");
        }

        public void Visit(ShapeGroup _shapeGroup)
        {
            Console.WriteLine($"Position : ({_shapeGroup.X};{_shapeGroup.Y})");
        }
    }
}