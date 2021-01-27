using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVisitorPattern
{
    public class Circle : Shape
    {
        public int Radius
        {
            get; private set;
        }

        public Circle(int _radius) : base(0, 0)
        {
            Radius = _radius;
        }

        public Circle(int _x, int _y, int _radius) : base(_x, _y)
        {
            Radius = _radius;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
