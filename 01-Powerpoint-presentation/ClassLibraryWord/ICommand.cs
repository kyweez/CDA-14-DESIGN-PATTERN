namespace ClassLibraryWord
{
    public interface ICommand
    {
        bool Execute();
        bool Undo();
    }
}