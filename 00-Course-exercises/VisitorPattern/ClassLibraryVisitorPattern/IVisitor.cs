namespace ClassLibraryVisitorPattern
{
    public interface IVisitor
    {
        void Visit(Circle circle);
        void Visit(Rectangle rectangle);
        void Visit(ShapeGroup shapeGroup);
    }
}