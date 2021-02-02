using ClassLibraryWord;
using System.Collections.Generic;

namespace ClassLibraryWordCommand
{
    public class CommandHistory
    {
        #region ############### PROPERTIES ###############
        private Text Editor
        {
            get; set;
        }

        public int LastOperationIndex
        {
            get; private set;
        }

        public int CurrentOperationIndex
        {
            get; private set;
        }

        public Dictionary<int, Command> History
        {
            get; private set;
        }
        #endregion

        #region ############### CONSTRUCTOR ###############
        public CommandHistory(Text _editor)
        {
            Editor = _editor;
            History = new Dictionary<int, Command>();
            LastOperationIndex = -1;
            CurrentOperationIndex = -1;
        }
        #endregion

        #region ############### METHODS ###############
        public void Push(Command _command)
        {
            if (_command.IsOriginalCommand)
            {
                //_command.
                if (LastOperationIndex > CurrentOperationIndex)
                    DropSavedCommands();
                History.Add(++CurrentOperationIndex, _command);
                ++LastOperationIndex;
            }
        }

        public void PreviousCommand()
        {
            if (CurrentOperationIndex > 0)
                CurrentOperationIndex--;
        }

        private void DropSavedCommands()
        {
            while (LastOperationIndex > CurrentOperationIndex)
                History.Remove(LastOperationIndex--);
        }
        #endregion
    }
}
