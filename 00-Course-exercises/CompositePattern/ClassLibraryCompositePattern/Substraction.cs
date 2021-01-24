namespace ClassLibraryCompositePattern
{
    public class Substraction : Binary
    {
        public Substraction(Expression _firstOperand, Expression _secondOperand): base(_firstOperand, _secondOperand)
        {

        }

        public override int Evaluate()
        {
            return FirstOperand.Evaluate() - SecondOperand.Evaluate();
        }

        public override string Format()
        {
            return $"{ToString()} = {Evaluate()}";
        }

        public override string ToString()
        {
            return $"{FirstOperand} - {SecondOperand}";
        }
    }
}