namespace ClassLibraryVisitorPattern
{
    public interface IVisitor
    {
        void Visit(Circle circle);
        void Visit(Rectangle rectangle);
        void Visit(ShapeGroup shapeGroup);
    }
}

//namespace ClassLibraryVisitorPattern
//{
//    public interface IVisitor<T>
//    {
//        T Visit(Circle circle);
//        T Visit(Rectangle rectangle);
//        T Visit(ShapeGroup shapeGroup);
//    }
//}