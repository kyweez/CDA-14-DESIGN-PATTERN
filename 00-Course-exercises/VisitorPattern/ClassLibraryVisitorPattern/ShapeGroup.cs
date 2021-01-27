using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVisitorPattern
{
    public class ShapeGroup : Shape
    {
        private List<Shape> Shapes
        {
            get; set;
        }

        public ShapeGroup() : base(0, 0)
        {
            Shapes = new List<Shape>();
        }

        public ShapeGroup(int _x, int _y) : base(_x, _y)
        {
            Shapes = new List<Shape>();
        }
        
        public ShapeGroup(List<Shape> _shapes) : base(0, 0)
        {
            Shapes = _shapes;
        }
                
        public ShapeGroup(int _x, int _y, List<Shape> _shapes) : base(_x, _y)
        {
            Shapes = _shapes;
        }

        public override void Accept(IVisitor visitor)
        {
            foreach (Shape shape in Shapes)
                shape.Accept(visitor);
        }

        public bool AddShape(Shape shape)
        {
            if (!AlreadyExists(shape))
            {
                Shapes.Add(shape);
                return true;
            }
            else
                return false;
        }

        private bool AlreadyExists(Shape shape)
        {
            return Shapes.Contains(shape);
        }
    }
}
