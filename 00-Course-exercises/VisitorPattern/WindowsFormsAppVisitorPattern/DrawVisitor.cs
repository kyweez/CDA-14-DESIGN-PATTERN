using ClassLibraryVisitorPattern;
using System;
using System.Drawing;

namespace WindowsFormsAppVisitorPattern
{
    class DrawVisitor : IVisitor
    {
        private Graphics graphicalObject;
        private Pen pen;

        public DrawVisitor(Graphics _graphicalObject)
        {
            graphicalObject = _graphicalObject;
            pen = new Pen(Color.Red);
        }

        public void Visit(Circle circle)
        {
            graphicalObject.DrawEllipse(pen, circle.X, circle.Y, circle.Radius, circle.Radius);
        }

        public void Visit(ClassLibraryVisitorPattern.Rectangle rectangle)
        {
            graphicalObject.DrawRectangle(pen, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Length);
        }

        public void Visit(ShapeGroup shapeGroup)
        {
        }
    }
}