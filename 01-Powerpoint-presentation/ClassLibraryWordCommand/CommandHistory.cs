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

        private Dictionary<int, Command> History
        {
            get; set;
        }
        #endregion

        #region ############### CONSTRUCTOR ###############
        public CommandHistory(Text _editor)
        {
            Editor = _editor;
            History = new Dictionary<int, Command>();
            LastOperationIndex = 0;
            CurrentOperationIndex = 0;
        }
        #endregion

        #region ############### METHODS ###############
        public void Push(Command _command)
        {
            if (LastOperationIndex > CurrentOperationIndex)
                DropSavedCommands();
            History.Add(CurrentOperationIndex++, _command);
            LastOperationIndex++;
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
