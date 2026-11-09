using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point lastPoint;
        private string currentTool = "Pen"; 
        private Color currentColor = Color.Black;
        private int penWidth = 2;
        private int brushWidth = 12;
        private int eraserWidth = 25;

        public Form1()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
            }
            pictureBox1.Image = bmp;

        }
     
        private void btnPen_Click(object sender, EventArgs e)
        {
            currentTool = "Pen";
        }

        private void btnBrush_Click(object sender, EventArgs e)
        {
            currentTool = "Brush";
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            currentTool = "Eraser";
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Запоминаем её цвет
            currentColor = clickedButton.BackColor;

            // Опционально: если у вас есть большой квадрат-индикатор текущего цвета (например, picCurrentColor)
            // picCurrentColor.BackColor = currentColor;

            // Если был включен ластик, автоматически переключаем обратно на ручку
            if (currentTool == "Eraser")
            {
                currentTool = "Pen";
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                // Инициализируем графику напрямую из Image, установленного в PictureBox
                if (pictureBox1.Image == null) return;

                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    // Включаем сглаживание линий
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    if (currentTool == "Pen")
                    {
                        using (Pen pen = new Pen(currentColor, penWidth))
                        {
                            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                            g.DrawLine(pen, lastPoint, e.Location);
                        }
                    }
                    else if (currentTool == "Brush")
                    {
                        using (Pen brushPen = new Pen(currentColor, brushWidth))
                        {
                            brushPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                            brushPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                            g.DrawLine(brushPen, lastPoint, e.Location);
                        }
                    }
                    else if (currentTool == "Eraser")
                    {
                        // Ластик закрашивает всё строго в белый цвет
                        using (Pen eraserPen = new Pen(Color.White, eraserWidth))
                        {
                            eraserPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                            eraserPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                            g.DrawLine(eraserPen, lastPoint, e.Location);
                        }
                    }
                }

                // Запоминаем текущую координату для следующего шага
                lastPoint = e.Location;

                // Принудительно обновляем PictureBox, чтобы линия сразу появилась на экране
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }
        private void видToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void отобразитьПоВертикалиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void повернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnPasteFrom(object sender, EventArgs e)
        {

        }

        private void btnPaste(object sender, EventArgs e)
        {

        }

        private void повернутьНа90ВПравоToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
