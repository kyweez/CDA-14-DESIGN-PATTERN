using ClassLibraryWord;

namespace ClassLibraryWordCommand.ConcreteCommands
{
    public class ChangeColorCommand : Command
    {
        #region ############### PROPERTIES ###############
        private EnumColor Color
        {
            get; set;
        }
        #endregion

        #region ############### CONSTRUCTOR ###############
        public ChangeColorCommand(Text _editor, EnumColor _color) : base(_editor)
        {
            Color = _color;
        }
        #endregion

        #region ############### CONCRETE METHODS ###############
        public override void Execute()
        {
            Editor.ChangeColor(Color);
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