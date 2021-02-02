using ClassLibraryWord;
using ClassLibraryWordCommand;
using ClassLibraryWordCommand.ConcreteCommands;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WordApp
{
    public partial class WordForm : Form
    {
        #region ############### PROPERTIES ###############
        private Text Editor
        {
            get; set;
        }

        private CommandHistory Commands
        {
            get; set;
        }
        #endregion

        public WordForm()
        {
            // Initialization
            InitializeComponent();

            // Properties assignment
            Editor = new Text();
            Editor.TextHasChanged += Editor_TextHasChanged;
            Commands = new CommandHistory(Editor);

            // Populate HMI buttons
            toolStripColors.ComboBox.DataSource = Enum.GetNames(typeof(EnumColor));
            toolStripFont.ComboBox.DataSource = Enum.GetNames(typeof(EnumFont));
            PopulateColorMenu();
            PopulateFontMenu();

            // Update HMI
            UpdateHMI();
        }

        #region #################### METHODS ###############
        private void ChangeColor(EnumColor _textColor)
        {
            ChangeColorCommand ccc;
            ccc = new ChangeColorCommand(Editor, _textColor);
            Commands.Push(ccc);
            ccc.Execute();
        }

        private void ChangeFont(EnumFont _textFont)
        {
            ChangeFontCommand cfc;
            cfc = new ChangeFontCommand(Editor, _textFont);
            Commands.Push(cfc);
            cfc.Execute();
        }

        private void UpdateHMI()
        {
            if (Editor.IsBold)
                textBoxArea.Font = new Font($"{Editor.Font}", 12.0f, FontStyle.Bold);
            else
                textBoxArea.Font = new Font($"{Editor.Font}", 12.0f, FontStyle.Regular);
            textBoxArea.ForeColor = Color.FromName($"{Editor.Color}");
        }

        private void PopulateColorMenu()
        {
            foreach (EnumColor color in Enum.GetValues(typeof(EnumColor)))
            {
                colorsToolStripMenuItem.DropDownItems.Add($"{color}");
                colorsToolStripMenuItem.DropDownItems[colorsToolStripMenuItem.DropDownItems.Count - 1].Click += Color_MenuClick;
            }
        }

        private void PopulateFontMenu()
        {
            foreach (EnumFont font in Enum.GetValues(typeof(EnumFont)))
            {
                fontToolStripMenuItem.DropDownItems.Add($"{font}");
                fontToolStripMenuItem.DropDownItems[fontToolStripMenuItem.DropDownItems.Count - 1].Click += Font_MenuClick;
            }
        }

        #endregion

        #region #################### EVENTS ###############
        private void Bold_Click(object sender, EventArgs e)
        {
            ChangeBoldCommand cbc = new ChangeBoldCommand(Editor);
            Commands.Push(cbc);
            cbc.Execute();
        }

        private void Color_MenuClick(object sender, EventArgs e)
        {
            if (Enum.TryParse($"{sender}", out EnumColor textColor))
                ChangeColor(textColor);
        }

        private void Color_ComboClick(object sender, EventArgs e)
        {
            if (Enum.TryParse($"{toolStripColors.ComboBox.SelectedValue}", out EnumColor textColor))
                ChangeColor(textColor);
        }

        private void Editor_TextHasChanged(Text _currentText)
        {
            UpdateHMI();
        }

        private void Font_MenuClick(object sender, EventArgs e)
        {
            if (Enum.TryParse($"{sender}", out EnumFont textFont))
                ChangeFont(textFont);
        }

        private void Font_ComboClick(object sender, EventArgs e)
        {
            if (Enum.TryParse($"{toolStripFont.ComboBox.SelectedValue}", out EnumFont textFont))
                ChangeFont(textFont);
        }

        #endregion

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            Commands.History[Commands.CurrentOperationIndex].Undo();
            //Commands.CurrentOperationIndex--;

        }
    }
}