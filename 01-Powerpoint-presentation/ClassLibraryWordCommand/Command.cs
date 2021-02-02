using ClassLibraryWord;

namespace ClassLibraryWordCommand
{
    public abstract class Command
    {
        #region ############### PROPERTIES ###############
        public bool IsOriginalCommand
        {
            get; protected set;
        }
        protected Text Editor
        {
            get; set;
        }
        protected Text PreviousState
        {
            get; set;
        }
        #endregion

        #region ############### EVENT ###############
        public delegate void DelegateDo();
        public event DelegateDo UndoEvent;
        public event DelegateDo RedoEvent;
        #endregion

        #region ############### CONSTRUCTOR ###############
        public Command(Text _editor)
        {
            Editor = _editor;
            PreviousState = Editor.CopyCurrentState();
            IsOriginalCommand = true;
        }
        #endregion

        #region ############### ABSTRACT METHODS ###############
        public abstract void Execute();
        public abstract void Undo();
        public abstract void Redo();
        #endregion

        public void SendEvent()
        {
            if (UndoEvent != null)
                UndoEvent();
        }
    }
}