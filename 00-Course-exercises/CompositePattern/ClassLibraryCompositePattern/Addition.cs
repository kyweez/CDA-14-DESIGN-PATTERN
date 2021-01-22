namespace ClassLibraryCompositePattern
{
    public class Addition : Binary
    {
        public Addition(Expression _firstOperand, Expression _secondOperand): base(_firstOperand, _secondOperand)
        {

        }

        public override int Evaluate()
        {
            return 1;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}