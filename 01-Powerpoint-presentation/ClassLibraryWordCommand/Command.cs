using ClassLibraryWord;

namespace ClassLibraryWordCommand
{
    public abstract class Command
    {
        protected Text Editor
        {
            get; set;
        }

        public Command(Text _editor)
        {
            Editor = _editor;
        }

        public abstract void Execute();
    }
}