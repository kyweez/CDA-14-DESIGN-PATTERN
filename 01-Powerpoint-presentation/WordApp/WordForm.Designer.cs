
namespace WordApp
{
    partial class WordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripColors = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripBold = new System.Windows.Forms.ToolStripButton();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonRedo = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(16, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(605, 35);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenu,
            this.redoMenu,
            this.toolStripSeparator2,
            this.colorsToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.boldToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(53, 27);
            this.editMenu.Text = "Edit";
            // 
            // undoMenu
            // 
            this.undoMenu.Image = ((System.Drawing.Image)(resources.GetObject("undoMenu.Image")));
            this.undoMenu.Name = "undoMenu";
            this.undoMenu.ShowShortcutKeys = false;
            this.undoMenu.Size = new System.Drawing.Size(224, 28);
            this.undoMenu.Text = "Undo";
            // 
            // redoMenu
            // 
            this.redoMenu.Image = ((System.Drawing.Image)(resources.GetObject("redoMenu.Image")));
            this.redoMenu.Name = "redoMenu";
            this.redoMenu.ShowShortcutKeys = false;
            this.redoMenu.Size = new System.Drawing.Size(224, 28);
            this.redoMenu.Text = "Redo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.colorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorsToolStripMenuItem.Image")));
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.ShowShortcutKeys = false;
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.ShowShortcutKeys = false;
            this.redToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.redToolStripMenuItem.Text = "Red";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.ShowShortcutKeys = false;
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.greenToolStripMenuItem.Text = "Green";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.ShowShortcutKeys = false;
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.blueToolStripMenuItem.Text = "Blue";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arialToolStripMenuItem,
            this.calibriToolStripMenuItem});
            this.fontToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fontToolStripMenuItem.Image")));
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShowShortcutKeys = false;
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // arialToolStripMenuItem
            // 
            this.arialToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.arialToolStripMenuItem.Name = "arialToolStripMenuItem";
            this.arialToolStripMenuItem.ShowShortcutKeys = false;
            this.arialToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.arialToolStripMenuItem.Text = "Arial";
            // 
            // calibriToolStripMenuItem
            // 
            this.calibriToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.calibriToolStripMenuItem.Name = "calibriToolStripMenuItem";
            this.calibriToolStripMenuItem.ShowShortcutKeys = false;
            this.calibriToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.calibriToolStripMenuItem.Text = "Calibri";
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("boldToolStripMenuItem.Image")));
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.ShowShortcutKeys = false;
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.boldToolStripMenuItem.Text = "Bold";
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUndo,
            this.toolStripRedo,
            this.toolStripSeparator1,
            this.toolStripColors,
            this.toolStripFont,
            this.toolStripBold});
            this.toolStrip.Location = new System.Drawing.Point(0, 35);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(605, 35);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripUndo
            // 
            this.toolStripUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUndo.Image")));
            this.toolStripUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUndo.Name = "toolStripUndo";
            this.toolStripUndo.Size = new System.Drawing.Size(29, 32);
            this.toolStripUndo.Text = "toolStripButton1";
            // 
            // toolStripRedo
            // 
            this.toolStripRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRedo.Image")));
            this.toolStripRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRedo.Name = "toolStripRedo";
            this.toolStripRedo.Size = new System.Drawing.Size(29, 32);
            this.toolStripRedo.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripColors
            // 
            this.toolStripColors.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripColors.Name = "toolStripColors";
            this.toolStripColors.Size = new System.Drawing.Size(121, 35);
            // 
            // toolStripFont
            // 
            this.toolStripFont.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripFont.Name = "toolStripFont";
            this.toolStripFont.Size = new System.Drawing.Size(121, 35);
            // 
            // toolStripBold
            // 
            this.toolStripBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBold.Image")));
            this.toolStripBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBold.Name = "toolStripBold";
            this.toolStripBold.Size = new System.Drawing.Size(56, 32);
            this.toolStripBold.Text = "Bold";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(15, 89);
            this.textBoxArea.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxArea.Multiline = true;
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(575, 252);
            this.textBoxArea.TabIndex = 2;
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(202, 368);
            this.buttonUndo.Margin = new System.Windows.Forms.Padding(6);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(188, 55);
            this.buttonUndo.TabIndex = 3;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            // 
            // buttonRedo
            // 
            this.buttonRedo.Location = new System.Drawing.Point(402, 368);
            this.buttonRedo.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(188, 55);
            this.buttonRedo.TabIndex = 4;
            this.buttonRedo.Text = "Redo";
            this.buttonRedo.UseVisualStyleBackColor = true;
            // 
            // WordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 463);
            this.Controls.Add(this.buttonRedo);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.6F);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WordForm";
            this.Text = "WordApp";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoMenu;
        private System.Windows.Forms.ToolStripMenuItem redoMenu;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripUndo;
        private System.Windows.Forms.ToolStripButton toolStripRedo;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripColors;
        private System.Windows.Forms.ToolStripComboBox toolStripFont;
        private System.Windows.Forms.ToolStripButton toolStripBold;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibriToolStripMenuItem;
    }
}