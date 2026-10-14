using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Leasons
{
    public partial class frmNotebook : Form
    {
        private string currentFilePath = null;
        private int checkPrint = 0;

        public frmNotebook()
        {
            InitializeComponent();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                var result = MessageBox.Show("Создать новый документ? Несохраненные изменения будут потеряны.", "Новый файл", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) return;
            }

            richTextBox1.Clear();
            currentFilePath = null;
            this.Text = "Блокнот";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.Title = "Открыть текстовый файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);

                        currentFilePath = openFileDialog.FileName;
                        this.Text = "Блокнот - " + Path.GetFileName(currentFilePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось открыть файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Текстовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog.Title = "Сохранить файл как...";
                saveFileDialog.DefaultExt = "txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveTextToFile(saveFileDialog.FileName);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                сохранитьКакToolStripMenuItem_Click(sender, e);
            }
            else
            {
                SaveTextToFile(currentFilePath);
            }
        }

        private void SaveTextToFile(string path)
        {
            try
            {
                File.WriteAllText(path, richTextBox1.Text);

                currentFilePath = path;
                this.Text = "Блокнот - " + Path.GetFileName(currentFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void параметрыСтраницыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = richTextBox1.Font;
                fontDialog.Color = richTextBox1.ForeColor;
                fontDialog.ShowColor = true; 

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Font = fontDialog.Font;
                    richTextBox1.ForeColor = fontDialog.Color;
                }
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmNotebook_Load(object sender, EventArgs e)
        {

        }

    }
}
