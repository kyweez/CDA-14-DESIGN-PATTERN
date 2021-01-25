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

        public override string Format()
        {
            if (Value > 0)
                return $"{Value} = {Value}";
            else
                return $"{Value} = ({Value})";
        }

        public override string ToString()
        {
            if (Value > 0)
                return Value.ToString();
            else
                return $"({Value})";
        }
    }
}