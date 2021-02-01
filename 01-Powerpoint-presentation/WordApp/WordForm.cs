using ClassLibraryWord;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WordApp
{
    public partial class WordForm : Form
    {
        public WordForm()
        {
            InitializeComponent();
            toolStripColors.ComboBox.DataSource = Enum.GetNames(typeof(EnumColor));
            toolStripFont.ComboBox.DataSource = Enum.GetNames(typeof(EnumFont));
            PopulateColorMenu();
            PopulateFontMenu();
            
            textBoxArea.Font = new Font(EnumFont.Algerian.ToString(), 12.0f);

        }

        private void PopulateColorMenu()
        {
            foreach (EnumColor color in Enum.GetValues(typeof(EnumColor)))
                colorsToolStripMenuItem.DropDownItems.Add($"{color}");
        }

        private void PopulateFontMenu()
        {
            foreach (EnumFont font in Enum.GetValues(typeof(EnumFont)))
                fontToolStripMenuItem.DropDownItems.Add($"{font}");
        }
    }
}