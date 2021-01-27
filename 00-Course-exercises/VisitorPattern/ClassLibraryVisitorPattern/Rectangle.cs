using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVisitorPattern
{
    public class Rectangle : Shape
    {
        public int Length
        {
            get; private set;
        }

        public int Width
        {
            get; private set;
        }

        public Rectangle(int _length, int _width) : base(0, 0)
        {
            Length = _length;
            Width = _width;
        }
        
        public Rectangle(int _x, int _y, int _length, int _width) : base(_x, _y)
        {
            Length = _length;
            Width = _width;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
