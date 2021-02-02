using ClassLibraryWord;

namespace ClassLibraryWordCommand.ConcreteCommands
{
    public class ChangeFontCommand : Command
    {
        #region ############### PROPERTIES ###############
        private EnumFont Font
        {
            get; set;
        }
        #endregion

        #region ############### CONSTRUCTOR ###############
        public ChangeFontCommand(Text _editor, EnumFont _font) : base(_editor)
        {
            Font = _font;
        }
        #endregion

        #region ############### CONCRETE METHODS ###############
        public override void Execute()
        {
            Editor.ChangeFont(Font);
            if (IsOriginalCommand)
                IsOriginalCommand = false;
        }

        public override void Undo()
        {
            //UndoEvent();
        }

        public override void Redo()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}