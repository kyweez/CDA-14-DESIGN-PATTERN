using ClassLibraryWord;

namespace ClassLibraryWordCommand.ConcreteCommands
{
    public class ChangeColorCommand : Command
    {
        private EnumColor Color
        {
            get; set;
        }

        public ChangeColorCommand(Text _editor, EnumColor _color) : base(_editor)
        {
            Color = _color;
        }

        public override void Execute()
        {
            Editor.ChangeColor(Color);
        }
    }
}