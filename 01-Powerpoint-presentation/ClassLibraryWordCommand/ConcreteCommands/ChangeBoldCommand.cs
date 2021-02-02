using ClassLibraryWord;

namespace ClassLibraryWordCommand.ConcreteCommands
{
    public class ChangeBoldCommand : Command
    {
        public ChangeBoldCommand(Text _editor):base(_editor)
        {
        }

        public override void Execute()
        {
            Editor.ChangeBold();
        }
    }
}