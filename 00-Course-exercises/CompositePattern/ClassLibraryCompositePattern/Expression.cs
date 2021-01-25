namespace ClassLibraryCompositePattern
{
    public abstract class Expression
    {
        public abstract int Evaluate();

        public virtual string Format()
        {
            return $"{ToString()} = {Evaluate()}";
        }
    }
}