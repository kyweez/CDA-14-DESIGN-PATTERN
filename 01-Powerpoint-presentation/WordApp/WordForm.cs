using ClassLibraryWord;
using ClassLibraryWordCommand;
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

        private CommandHistory History
        {
            get; set;
        }
        #endregion

        public WordForm()
        {
            // Initialization
            InitializeComponent();

            // Populate HMI buttons
            toolStripColors.ComboBox.DataSource = Enum.GetNames(typeof(EnumColor));
            toolStripFont.ComboBox.DataSource = Enum.GetNames(typeof(EnumFont));
            PopulateColorMenu();
            PopulateFontMenu();

            // Properties assignment
            Editor = new Text();
            Editor.TextHasChanged += Editor_TextHasChanged;
            History = new CommandHistory(Editor);

            // Update HMI
            UpdateHMI();
        }

        #region #################### METHODS ###############
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
                colorsToolStripMenuItem.DropDownItems[colorsToolStripMenuItem.DropDownItems.Count - 1].Click += Color_Click;
            }
        }

        private void PopulateFontMenu()
        {
            foreach (EnumFont font in Enum.GetValues(typeof(EnumFont)))
            {
                fontToolStripMenuItem.DropDownItems.Add($"{font}");
                fontToolStripMenuItem.DropDownItems[fontToolStripMenuItem.DropDownItems.Count - 1].Click += Font_Click;
            }
        }
        #endregion

        #region #################### EVENTS ###############
        private void BoldEvent(object sender, EventArgs e)
        {

        }

        private void Color_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Font_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Editor_TextHasChanged(Text _currentText)
        {
            UpdateHMI();
        }
        #endregion
    }
}