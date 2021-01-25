using System;
using ClassLibraryCompositePattern;

namespace ConsoleAppCompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression exp1 = new Addition(new Number(2), new Number(5));
            Console.WriteLine(exp1.Format());
                        
            Expression exp2 = new Addition(new Number(3), new Addition(new Number(4), new Number(10)));
            Console.WriteLine(exp2.Format());
                        
            Expression exp3 = new Substraction(new Number(2), new Number(5));
            Console.WriteLine(exp3.Format());
                        
            Expression exp4 = new Addition(new Substraction(new Number(13), new Number(3)), new Number(10));
            Console.WriteLine(exp4.Format());

            Expression exp5 = new Substraction(new Substraction(new Number(21), new Number(15)), new Substraction(new Number(12), new Number(51)));
            Console.WriteLine(exp5.Format());

        }
    }
}
