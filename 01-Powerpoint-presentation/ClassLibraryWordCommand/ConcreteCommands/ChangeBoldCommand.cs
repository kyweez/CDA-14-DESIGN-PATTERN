using ClassLibraryWord;

namespace ClassLibraryWordCommand.ConcreteCommands
{
    public class ChangeBoldCommand : Command
    {
        #region ############### CONSTRUCTOR ###############
        public ChangeBoldCommand(Text _editor):base(_editor)
        {
        }
        #endregion

        #region ############### CONCRETE METHODS ###############
        public override void Execute()
        {
            Editor.ChangeBold();
            if (IsOriginalCommand)
                IsOriginalCommand = false;
        }

        public override void Redo()
        {
            throw new System.NotImplementedException();
        }

        public override void Undo()
        {
            Editor.ChangeBold();
            SendEvent();
        }
        #endregion
    }
}