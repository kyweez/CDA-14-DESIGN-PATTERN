using ClassLibraryWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryWordCommand
{
    public abstract class Command
    {
        protected Text Editor
        {
            get; set;
        }

        public Command(Text _editor)
        {
            Editor = _editor;
        }

        public abstract void Execute();
    }
}
