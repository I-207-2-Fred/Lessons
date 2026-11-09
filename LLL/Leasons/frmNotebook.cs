using System;
using System.Windows.Forms;

namespace Leasons
{
    public partial class frmNotebook : Form
    {
        private string currentFilePath = null;
        public frmNotebook()
        {
            InitializeComponent();
        }
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Вы хотите сохранить изменения в файле?", "Notebook", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Документ RTF (*.rtf)|*.rtf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        SaveTextToFile(saveFileDialog.FileName);
                    }
                }
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    richTextBox1.Clear();
                }
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Документ RTF (*.rtf)|*.rtf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                richTextBox1.LoadFile(currentFilePath, RichTextBoxStreamType.RichText);
            }
        }
        private void savehowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Документ RTF (*.rtf)|*.rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveTextToFile(saveFileDialog.FileName);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFilePath == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Документ RTF (*.rtf)|*.rtf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveTextToFile(saveFileDialog.FileName);
                }
            }
            else
            {
                SaveTextToFile(currentFilePath);
            }
        }
        private void SaveTextToFile(string path)
        {
            richTextBox1.SaveFile(path, RichTextBoxStreamType.RichText);
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        private void btnCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        private void btnPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        private void btnDateTime_Click(object sender, EventArgs e)
        {
            string currentDateTime = DateTime.Now.ToString();
            richTextBox1.SelectedText = currentDateTime;
        }
        private void btnStatusStrip(object sender, EventArgs e)
        {
            if (statusStrip1.Visible == true)
            {
                statusStrip1.Visible = false;
            }
            else
            {
                statusStrip1.Visible = true;
            }
        }
        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Color = richTextBox1.ForeColor;
            fontDialog.ShowColor = true;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
                richTextBox1.SelectionColor = fontDialog.Color;
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }
        private void multilinebtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Multiline == false)
            {
                richTextBox1.Multiline = true;
            }
            else
            {
                richTextBox1.Multiline = false;
            }
        }
    }
}