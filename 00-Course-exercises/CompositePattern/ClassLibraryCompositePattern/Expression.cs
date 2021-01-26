namespace ClassLibraryCompositePattern
{
    public abstract class Expression
    {
        public abstract int Evaluate();

        public string Format()
        {
            return $"{ToString()} = {Evaluate()}";
        }
    }
}