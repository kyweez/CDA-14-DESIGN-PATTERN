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
            ConsoleVisitor visitor_1 = new ConsoleVisitor();

            // Visit 1 : rectangle_1
            Console.WriteLine("\nVisit 1: Rectangle 1\n====================\n");
            rectangle_1.Accept(visitor_1);

            // Visit 2 : rectangle_2
            Console.WriteLine("\nVisit 2: Rectangle 2\n====================\n");
            rectangle_2.Accept(visitor_1);

            // Visit 3 : circle_1
            Console.WriteLine("\nVisit 3: Circle 1\n=================\n");
            circle_1.Accept(visitor_1);

            // Visit 4 : circle_2
            Console.WriteLine("\nVisit 4: Circle 2\n=================\n");
            circle_2.Accept(visitor_1);
            Console.ReadLine();
        }
    }
}
