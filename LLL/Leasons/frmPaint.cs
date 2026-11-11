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
    public partial class frmPaint : Form
    {
        Graphics graphics;
        bool draw = false;
        string tool = "";
        Color color = Color.Black;
        Point startPoint;
        Point endPoint;
        Bitmap tempBitmap;
        public frmPaint()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            tool = "Ручка";
        }
        private void btnBrush_Click(object sender, EventArgs e)
        {
            tool = "Кисть";
        }
        private void btnEraser_Click(object sender, EventArgs e)
        {
            tool = "Ластик";
        }
        private void btnEllipse_Click(object sender, EventArgs e)
        {
            tool = "Овал";
        }
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            tool = "Квадрат";
        }
        private void btnTriangle_Click(object sender, EventArgs e)
        {
            tool = "Треугольник";
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            tool = "Линия";
        }
        private void btnAngleTriangle_Click(object sender, EventArgs e)
        {
            tool = "Прямоугольный треугольник";
        }
        private void ColorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            color = button.BackColor;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            endPoint = e.Location;
            startPoint = e.Location;
            tempBitmap = new Bitmap((Bitmap)pictureBox1.Image);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int penWidth = 2;
            int brushWidth = 10;
            int eraserWidth = 20;
            if (draw == false)
                return;
            if (tool == "Ручка" || tool == "Кисть" || tool == "Ластик")
            {
                Pen pen = new Pen(color, penWidth);
                if (tool == "Ручка")
                    pen.StartCap = pen.EndCap = LineCap.Round;
                if (tool == "Кисть")
                    pen = new Pen(color, brushWidth);
                pen.StartCap = pen.EndCap = LineCap.Round;
                if (tool == "Ластик")
                    pen = new Pen(Color.White, eraserWidth);
                pen.StartCap = pen.EndCap = LineCap.Round;
                graphics.DrawLine(pen, endPoint, e.Location);
                endPoint = e.Location;
            }
            else
            {
                graphics.Dispose();
                pictureBox1.Image = new Bitmap(tempBitmap);
                graphics = Graphics.FromImage(pictureBox1.Image);
                Pen pen = new Pen(color, penWidth);
                int x = Math.Min(startPoint.X, e.X);
                int y = Math.Min(startPoint.Y, e.Y);
                int width = Math.Abs(e.X - startPoint.X);
                int height = Math.Abs(e.Y - startPoint.Y);
                if (tool == "Квадрат")
                {
                    graphics.DrawRectangle(pen, x, y, width, height);
                }
                if (tool == "Овал")
                {
                    graphics.DrawEllipse(pen, x, y, width, height);
                }
                if (tool == "Треугольник")
                {
                    Point point1 = new Point(x + width / 2, y);
                    Point point2 = new Point(x, y + height);
                    Point point3 = new Point(x + width, y + height);
                    graphics.DrawPolygon(pen, new Point[] { point1, point2, point3 });
                }
                if (tool == "Линия")
                {
                    graphics.DrawLine(pen, startPoint, e.Location);
                }
                if (tool == "Прямоугольный треугольник")
                {
                    Point point1 = startPoint;
                    Point point2 = new Point(startPoint.X, e.Y);
                    Point point3 = e.Location;
                    graphics.DrawPolygon(pen, new Point[] { point1, point2, point3 });
                }
            }
            pictureBox1.Refresh();
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            tempBitmap = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBox1.Invalidate(); 
        }

        private void checkFilling_Click(object sender, EventArgs e)
        {

        }
    }
}
