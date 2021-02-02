using ClassLibraryWord;
using System;

namespace ClassLibraryWordCommand.ConcreteCommands
{
    class UndoCommand : Command
    {
        public UndoCommand(Text _editor) : base(_editor)
        {
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
