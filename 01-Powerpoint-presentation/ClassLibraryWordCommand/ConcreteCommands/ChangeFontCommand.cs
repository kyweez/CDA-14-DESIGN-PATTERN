using ClassLibraryWord;

namespace ClassLibraryWordCommand.ConcreteCommands
{
    class ChangeFontCommand : Command
    {
        private EnumFont Font
        {
            get; set;
        }

        public ChangeFontCommand(Text _editor, EnumFont _font) : base(_editor)
        {
            Font = _font;
        }

        public override void Execute()
        {
            Editor.ChangeFont(Font);
        }
    }
}