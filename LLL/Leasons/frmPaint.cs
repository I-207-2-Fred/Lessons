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
        bool draw = false;
        Point oldPoint;
        string tool = "Pen";
        Color color = Color.Black;
        Point startPoint;
        Point endPoint;
        int penWidth = 2;
        int brushWidth = 10;
        int eraserWidth = 20;
        Bitmap tempBitmap;
        public frmPaint()
        {
            InitializeComponent();

            Bitmap bmp = new Bitmap(1200, 800);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            tool = "Pen";
        }

        private void btnBrush_Click(object sender, EventArgs e)
        {
            tool = "Brush";
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            tool = "Eraser";
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            color = b.BackColor;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            oldPoint = e.Location;
            startPoint = e.Location;
            tempBitmap = new Bitmap((Bitmap)pictureBox1.Image);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!draw)
                return;

            // Карандаш, кисть, ластик
            if (tool == "Pen" || tool == "Brush" || tool == "Eraser")
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);

                Pen pen;

                if (tool == "Pen")
                    pen = new Pen(color, 2);
                else if (tool == "Brush")
                    pen = new Pen(color, 10);
                else
                    pen = new Pen(Color.White, 20);

                g.DrawLine(pen, oldPoint, e.Location);

                oldPoint = e.Location;

                pictureBox1.Refresh();
            }
            else
            {
                pictureBox1.Image = new Bitmap(tempBitmap);

                Graphics g = Graphics.FromImage(pictureBox1.Image);

                int x = Math.Min(startPoint.X, e.X);
                int y = Math.Min(startPoint.Y, e.Y);

                int width = Math.Abs(e.X - startPoint.X);
                int height = Math.Abs(e.Y - startPoint.Y);

                Pen p = new Pen(color, 2);

                if (tool == "Rectangle")
                {
                    g.DrawRectangle(p, x, y, width, height);
                }
                else if (tool == "Square")
                {
                    int side = Math.Min(width, height);
                    g.DrawRectangle(p, x, y, side, side);
                }
                else if (tool == "Oval")
                {
                    g.DrawEllipse(p, x, y, width, height);
                }
                else if (tool == "Triangle")
                {
                    Point p1 = new Point(x + width / 2, y);
                    Point p2 = new Point(x, y + height);
                    Point p3 = new Point(x + width, y + height);

                    g.DrawPolygon(p, new Point[] { p1, p2, p3 });
                }

                pictureBox1.Refresh();
            }
        }
        private void btnOval_Click(object sender, EventArgs e)
        {
            tool = "Oval";
        }
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            tool = "Rectangle";
        }
        private void btnSquare_Click(object sender, EventArgs e)
        {
            tool = "Square";
        }
        private void btnTriangle_Click(object sender, EventArgs e)
        {
            tool = "Triangle";
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;

            if (tool == "Pen" || tool == "Brush" || tool == "Eraser")
                return;
            endPoint = e.Location;
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            Pen p = new Pen(color, penWidth);
            int x = Math.Min(startPoint.X, endPoint.X);
            int y = Math.Min(startPoint.Y, endPoint.Y);
            int width = Math.Abs(endPoint.X - startPoint.X);
            int height = Math.Abs(endPoint.Y - startPoint.Y);
            if (tool == "Rectangle")
            {
                g.DrawRectangle(p, x, y, width, height);
            }
            else if (tool == "Square")
            {
                int side = Math.Min(width, height);
                g.DrawRectangle(p, x, y, side, side);
            }
            else if (tool == "Oval")
            {
                g.DrawEllipse(p, x, y, width, height);
            }
            else if (tool == "Triangle")
            {
                Point p1 = new Point(x + width / 2, y);
                Point p2 = new Point(x, y + height);
                Point p3 = new Point(x + width, y + height);
                g.DrawPolygon(p, new Point[] { p1, p2, p3 });
            }
            pictureBox1.Refresh();
            tempBitmap = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
