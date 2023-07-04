namespace MyNotepad
{
    partial class MainMyNotepadForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMyNotepadForm));
            MainRichTextBox = new RichTextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            dateTimeToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem1 = new ToolStripMenuItem();
            boldToolStripMenuItem = new ToolStripMenuItem();
            italicToolStripMenuItem = new ToolStripMenuItem();
            underlineToolStripMenuItem = new ToolStripMenuItem();
            strikeThroughToolStripMenuItem = new ToolStripMenuItem();
            textColorToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            wordWrapToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainRichTextBox
            // 
            MainRichTextBox.Dock = DockStyle.Fill;
            MainRichTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MainRichTextBox.Location = new Point(0, 24);
            MainRichTextBox.Name = "MainRichTextBox";
            MainRichTextBox.Size = new Size(800, 426);
            MainRichTextBox.TabIndex = 0;
            MainRichTextBox.Text = "";
            MainRichTextBox.TextChanged += MainRichTextBox_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, fontToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, printPreviewToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = Properties.Resources.new_file;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(186, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = Properties.Resources.open_file;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(186, 22);
            openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = Properties.Resources.save_file;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(186, 22);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Image = Properties.Resources.save_as_file;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(186, 22);
            saveAsToolStripMenuItem.Text = "&Save As";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = Properties.Resources.print_file;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printPreviewToolStripMenuItem.Size = new Size(186, 22);
            printPreviewToolStripMenuItem.Text = "&Print";
            printPreviewToolStripMenuItem.Click += printPreviewToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.exit;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(186, 22);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, selectAllToolStripMenuItem, dateTimeToolStripMenuItem, wordWrapToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Image = Properties.Resources.undo;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(180, 22);
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Image = Properties.Resources.redo;
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            redoToolStripMenuItem.Size = new Size(180, 22);
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Image = Properties.Resources.select_all;
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(180, 22);
            selectAllToolStripMenuItem.Text = "&Select All";
            // 
            // dateTimeToolStripMenuItem
            // 
            dateTimeToolStripMenuItem.Image = Properties.Resources.date_time;
            dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            dateTimeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            dateTimeToolStripMenuItem.Size = new Size(180, 22);
            dateTimeToolStripMenuItem.Text = "&Date/Time";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem1, boldToolStripMenuItem, italicToolStripMenuItem, underlineToolStripMenuItem, strikeThroughToolStripMenuItem, textColorToolStripMenuItem });
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            fontToolStripMenuItem.Size = new Size(43, 20);
            fontToolStripMenuItem.Text = "&Font";
            // 
            // fontToolStripMenuItem1
            // 
            fontToolStripMenuItem1.Image = Properties.Resources.font;
            fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            fontToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.F;
            fontToolStripMenuItem1.Size = new Size(223, 22);
            fontToolStripMenuItem1.Text = "&Font";
            fontToolStripMenuItem1.Click += fontToolStripMenuItem1_Click;
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Image = Properties.Resources.Bold;
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            boldToolStripMenuItem.Size = new Size(223, 22);
            boldToolStripMenuItem.Text = "&Bold";
            // 
            // italicToolStripMenuItem
            // 
            italicToolStripMenuItem.Image = Properties.Resources.italic;
            italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            italicToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            italicToolStripMenuItem.Size = new Size(223, 22);
            italicToolStripMenuItem.Text = "&Italic";
            // 
            // underlineToolStripMenuItem
            // 
            underlineToolStripMenuItem.Image = Properties.Resources.underline_text;
            underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            underlineToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            underlineToolStripMenuItem.Size = new Size(223, 22);
            underlineToolStripMenuItem.Text = "&Underline";
            // 
            // strikeThroughToolStripMenuItem
            // 
            strikeThroughToolStripMenuItem.Image = Properties.Resources.strike_through_text;
            strikeThroughToolStripMenuItem.Name = "strikeThroughToolStripMenuItem";
            strikeThroughToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.T;
            strikeThroughToolStripMenuItem.Size = new Size(223, 22);
            strikeThroughToolStripMenuItem.Text = "&Strike Through";
            // 
            // textColorToolStripMenuItem
            // 
            textColorToolStripMenuItem.Image = Properties.Resources.text_color;
            textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            textColorToolStripMenuItem.Size = new Size(223, 22);
            textColorToolStripMenuItem.Text = "&Text Color";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(52, 20);
            helpToolStripMenuItem.Text = "&About";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // wordWrapToolStripMenuItem
            // 
            wordWrapToolStripMenuItem.Image = Properties.Resources.wrap_text;
            wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            wordWrapToolStripMenuItem.Size = new Size(180, 22);
            wordWrapToolStripMenuItem.Text = "Word Wrap";
            // 
            // MainMyNotepadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainRichTextBox);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainMyNotepadForm";
            Text = "Untitled - MyNotepad";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox MainRichTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem dateTimeToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem1;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicToolStripMenuItem;
        private ToolStripMenuItem underlineToolStripMenuItem;
        private ToolStripMenuItem strikeThroughToolStripMenuItem;
        private ToolStripMenuItem textColorToolStripMenuItem;
        private ToolStripMenuItem wordWrapToolStripMenuItem;
    }
}