using ClassLibraryWord;
using System;

namespace ClassLibraryWordCommand.ConcreteCommands
{
    class RedoCommand : Command
    {
        public RedoCommand(Text _editor) : base(_editor)
        {
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}