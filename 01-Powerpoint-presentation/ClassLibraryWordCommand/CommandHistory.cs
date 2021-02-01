using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryWordCommand
{
    public class CommandHistory
    {
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

        public CommandHistory()
        {
            History = new Dictionary<int, Command>();
            LastOperationIndex = 0;
            CurrentOperationIndex = 0;
        }

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
    }
}
