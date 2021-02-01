namespace ClassLibraryCommandPattern
{
    public interface ICommand
    {
        void Call();
        void Undo();
    }
}