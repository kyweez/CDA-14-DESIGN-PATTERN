namespace ClassLibraryCompositePattern
{
    public abstract class Binary : Expression
    {
        protected Expression FirstOperand
        {
            get; private set;
        }

        protected Expression SecondOperand
        {
            get; private set;
        }

        public Binary(Expression _firstOperand, Expression _secondOperand)
        {
            FirstOperand = _firstOperand;
            SecondOperand = _secondOperand;
        }
    }
}