namespace ClassLibraryCompositePattern
{
    public abstract class Binary : Expression
    {
        protected Expression FirstOperand
        {
            get; set;
        }

        protected Expression SecondOperand
        {
            get; set;
        }

        public Binary(Expression _firstOperand, Expression _secondOperand)
        {
            FirstOperand = _firstOperand;
            SecondOperand = _secondOperand;
        }

        public override abstract int Evaluate();
    }
}