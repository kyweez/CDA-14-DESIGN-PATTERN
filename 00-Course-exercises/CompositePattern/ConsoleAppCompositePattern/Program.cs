using System;
using ClassLibraryCompositePattern;

namespace ConsoleAppCompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Expression exp0 = new Number(-1);
            Console.WriteLine(exp0.Format());

            Expression exp1 = new Addition(new Number(2), new Number(5));
            Console.WriteLine(exp1.Format());
                        
            Expression exp2 = new Addition(new Number(3), new Addition(new Number(4), new Number(10)));
            Console.WriteLine(exp2.Format());
                        
            Expression exp3 = new Substraction(new Number(2), new Number(5));
            Console.WriteLine(exp3.Format());
                        
            Expression exp4 = new Addition(new Substraction(new Number(13), new Number(3)), new Number(10));
            Console.WriteLine(exp4.Format());

            Expression exp5 = new Substraction(new Substraction(new Number(-1), new Number(-2)), new Substraction(new Number(-3), new Number(-4)));
            Console.WriteLine(exp5.Format());

            Expression exp6 = new Substraction(new Addition(new Number(3), new Number(2)), new Addition(new Number(45), new Number(5)));
            Console.WriteLine(exp6.Format());

            Console.WriteLine(new Addition(exp1, new Substraction(new Addition(exp2, exp3), new Substraction(exp4, exp5))).Format());
        }
    }
}