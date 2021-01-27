using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVisitorPattern
{
    public abstract class Shape
    {
        public int X
        {
            get; protected set;
        }

        public int Y
        {
            get; protected set;
        }

        public Shape(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }

        public abstract void Accept(IVisitor visitor);
    }
}
