namespace MyNotepad
{
    public partial class MainMyNotepadForm : Form
    {
        public MainMyNotepadForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All rights reserved by the author\n\nCreated by: Ashik Khulal", "About MyNotepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Text = "";
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}