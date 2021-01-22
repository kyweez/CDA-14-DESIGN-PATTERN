namespace ClassLibraryCompositePattern
{
    public class Number : Expression
    {
        private int Value
        {
            get; set;
        }

        public Number(int _value)
        {
            Value = _value;
        }

        public override int Evaluate()
        {
            return Value;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}