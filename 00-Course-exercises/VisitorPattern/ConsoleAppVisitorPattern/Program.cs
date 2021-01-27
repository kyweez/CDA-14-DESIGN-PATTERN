using ClassLibraryVisitorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ############### FIRST TESTS ###############

            Console.WriteLine("#############################################");
            Console.WriteLine("###       FIRST TESTS (Simple tests)       ##");
            Console.WriteLine("#############################################\n");

            // Rectangle : Position (0,0) Length 10 Width 10
            Rectangle rectangle_1 = new Rectangle(10, 10);
            Console.WriteLine("Rectangle 1 creation : Position (0,0) Length 10 Width 10");

            // Rectangle : Position (1,2) Length 12 Width 15
            Rectangle rectangle_2 = new Rectangle(1, 2, 12, 15);
            Console.WriteLine("Rectangle 2 creation : Position (1,2) Length 12 Width 15");

            // Cercle : Position (0,0) Radius 10
            Circle circle_1 = new Circle(10);
            Console.WriteLine("Circle 1 creation : Position (0,0) Radius 10");

            // Cercle : Position (10,4) Radius 12
            Circle circle_2 = new Circle(10, 4, 11);
            Console.WriteLine("Circle 2 creation : Position (10,4) Radius 11");

            // Visitor creation
            Console.WriteLine("Visitor creation");
            ConsoleVisitor visitor = new ConsoleVisitor();

            // Visit 1 : rectangle_1
            Console.WriteLine("\nVisit 1: Rectangle 1\n====================\n");
            rectangle_1.Accept(visitor);

            // Visit 2 : rectangle_2
            Console.WriteLine("\nVisit 2: Rectangle 2\n====================\n");
            rectangle_2.Accept(visitor);

            // Visit 3 : circle_1
            Console.WriteLine("\nVisit 3: Circle 1\n=================\n");
            circle_1.Accept(visitor);

            // Visit 4 : circle_2
            Console.WriteLine("\nVisit 4: Circle 2\n=================\n");
            circle_2.Accept(visitor);


            Console.WriteLine("\n=================== EOF ===================");
            Console.WriteLine("Press any key to continue to a new test...");
            Console.ReadLine();
            Console.Clear();
            #endregion


            Console.WriteLine("#############################################");
            Console.WriteLine("###      SECOND TESTS (Shapes tests)       ##");
            Console.WriteLine("#############################################\n");

            // ShapeGroup 1 : Position (0,0) Empty group
            ShapeGroup group_1 = new ShapeGroup();
            Console.WriteLine("ShapeGroup 1 : Position (0,0) Empty group");

            // ShapeGroup 2 : Position (2,2) Empty group
            ShapeGroup group_2 = new ShapeGroup(2, 2);
            Console.WriteLine("ShapeGroup 2 : Position (2,2) Empty group");

            // Shape list creation and adding shapes
            List<Shape> shapeList_1 = new List<Shape>();
            shapeList_1.Add(rectangle_1);
            shapeList_1.Add(rectangle_2);
            shapeList_1.Add(circle_1);
            shapeList_1.Add(circle_2);
            group_1.AddShape(rectangle_1);
            group_2.AddShape(rectangle_2);
            Console.WriteLine("shapeList_1 creation and adding rectangle_1, rectangle_2, circle_1, circle_2,");

            // ShapeGroup 3 : Position (0,0) shapList_1 in argument
            ShapeGroup group_3 = new ShapeGroup(shapeList_1);
            Console.WriteLine("ShapeGroup 3 : Position (0,0) shapList_1 in argument");

            // ShapeGroup 4 : Position (4,4) shapList_1 in argument
            ShapeGroup group_4 = new ShapeGroup(4, 4, shapeList_1);
            Console.WriteLine("ShapeGroup 4 : Position (4,4) shapList_1 in argument");

            // Visit 1 : group_1
            Console.WriteLine("\nVisit 1: Shape Group 1\n======================\n");
            group_1.Accept(visitor);
            
            // Visit 2 : group_2
            Console.WriteLine("\nVisit 2: Shape Group 2\n======================\n");
            group_2.Accept(visitor);
            
            // Visit 3 : group_3
            Console.WriteLine("\nVisit 3: Shape Group 3\n======================\n");
            group_3.Accept(visitor);
            
            // Visit 4 : group_4
            Console.WriteLine("\nVisit 4: Shape Group 4\n======================\n");
            group_4.Accept(visitor);

            Console.WriteLine("\n=================== EOF ===================");
            Console.WriteLine("Press any key to close console...");
            Console.ReadLine();
        }
    }
}