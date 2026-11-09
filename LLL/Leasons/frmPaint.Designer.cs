namespace Leasons
{
    partial class frmPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaint));
            pctpaint = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            statusStrip1 = new StatusStrip();
            groupBox5 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            buttonBlue = new Button();
            buttonRed = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonBlack = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            pictureBox11 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox12 = new PictureBox();
            groupBox4 = new GroupBox();
            pictureBox15 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            buttoncopy = new Button();
            pictureBox2 = new PictureBox();
            menuStrip2 = new MenuStrip();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem1 = new ToolStripMenuItem();
            вставитьИзToolStripMenuItem = new ToolStripMenuItem();
            buttoncut = new Button();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)pctpaint).BeginInit();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // pctpaint
            // 
            pctpaint.Location = new Point(0, 199);
            pctpaint.Name = "pctpaint";
            pctpaint.Size = new Size(1085, 251);
            pctpaint.TabIndex = 10;
            pctpaint.TabStop = false;
            pctpaint.Click += pictureBox1_Click;
            pctpaint.MouseDown += pctpaint_MouseDown;
            pctpaint.MouseEnter += pictureBox1_MouseEnter;
            pctpaint.MouseMove += pctpaint_MouseMove;
            pctpaint.MouseUp += pctpaint_MouseUp;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1085, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button4);
            groupBox5.Controls.Add(button5);
            groupBox5.Controls.Add(button6);
            groupBox5.Controls.Add(button7);
            groupBox5.Controls.Add(buttonBlue);
            groupBox5.Controls.Add(buttonRed);
            groupBox5.Controls.Add(button8);
            groupBox5.Controls.Add(button9);
            groupBox5.Controls.Add(buttonBlack);
            groupBox5.Controls.Add(button3);
            groupBox5.Location = new Point(768, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(302, 121);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Text = "цвет";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HighlightText;
            button4.ForeColor = Color.DarkGoldenrod;
            button4.Location = new Point(260, 50);
            button4.Name = "button4";
            button4.Size = new Size(35, 27);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.HotPink;
            button5.ForeColor = Color.DarkGoldenrod;
            button5.Location = new Point(219, 48);
            button5.Name = "button5";
            button5.Size = new Size(35, 27);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 0, 64);
            button6.ForeColor = Color.DarkGoldenrod;
            button6.Location = new Point(180, 48);
            button6.Name = "button6";
            button6.Size = new Size(35, 27);
            button6.TabIndex = 4;
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Lime;
            button7.ForeColor = Color.DarkGoldenrod;
            button7.Location = new Point(140, 48);
            button7.Name = "button7";
            button7.Size = new Size(35, 27);
            button7.TabIndex = 4;
            button7.UseVisualStyleBackColor = false;
            // 
            // buttonBlue
            // 
            buttonBlue.BackColor = SystemColors.Highlight;
            buttonBlue.ForeColor = Color.DarkGoldenrod;
            buttonBlue.Location = new Point(260, 17);
            buttonBlue.Name = "buttonBlue";
            buttonBlue.Size = new Size(35, 27);
            buttonBlue.TabIndex = 3;
            buttonBlue.UseVisualStyleBackColor = false;
            // 
            // buttonRed
            // 
            buttonRed.BackColor = Color.Red;
            buttonRed.ForeColor = Color.DarkGoldenrod;
            buttonRed.Location = new Point(221, 15);
            buttonRed.Name = "buttonRed";
            buttonRed.Size = new Size(33, 27);
            buttonRed.TabIndex = 4;
            buttonRed.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 128, 0);
            button8.ForeColor = Color.White;
            button8.Location = new Point(74, 17);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 8;
            button8.Text = "цвет 2";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Black;
            button9.ForeColor = Color.White;
            button9.Location = new Point(8, 16);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 9;
            button9.Text = "цвет 2";
            button9.UseVisualStyleBackColor = false;
            // 
            // buttonBlack
            // 
            buttonBlack.BackColor = Color.Black;
            buttonBlack.ForeColor = Color.DarkGoldenrod;
            buttonBlack.Location = new Point(181, 14);
            buttonBlack.Name = "buttonBlack";
            buttonBlack.Size = new Size(34, 27);
            buttonBlack.TabIndex = 5;
            buttonBlack.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.ForeColor = Color.DarkGoldenrod;
            button3.Location = new Point(140, 16);
            button3.Name = "button3";
            button3.Size = new Size(35, 27);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(pictureBox11);
            groupBox3.Controls.Add(pictureBox14);
            groupBox3.Controls.Add(pictureBox9);
            groupBox3.Controls.Add(pictureBox13);
            groupBox3.Controls.Add(pictureBox10);
            groupBox3.Controls.Add(pictureBox12);
            groupBox3.FlatStyle = FlatStyle.Popup;
            groupBox3.Location = new Point(381, -3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(137, 124);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "инструменты";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(68, 40);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(19, 19);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 15;
            pictureBox11.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(68, 65);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(19, 19);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 18;
            pictureBox14.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(18, 40);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(19, 19);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 13;
            pictureBox9.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(43, 65);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(19, 19);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 17;
            pictureBox13.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(43, 41);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(19, 19);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 14;
            pictureBox10.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(18, 65);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(19, 19);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 16;
            pictureBox12.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.AutoSize = true;
            groupBox4.Controls.Add(pictureBox15);
            groupBox4.FlatStyle = FlatStyle.Popup;
            groupBox4.Location = new Point(515, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(247, 121);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "фигуры";
            // 
            // pictureBox15
            // 
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.Location = new Point(3, 13);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(72, 68);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 19;
            pictureBox15.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(192, -3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(196, 121);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "изображения";
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(buttoncopy);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(menuStrip2);
            groupBox2.Controls.Add(buttoncut);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1085, 143);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "буфер обмена";
            // 
            // buttoncopy
            // 
            buttoncopy.BackColor = Color.SeaShell;
            buttoncopy.Location = new Point(115, 59);
            buttoncopy.Name = "buttoncopy";
            buttoncopy.Size = new Size(71, 23);
            buttoncopy.TabIndex = 22;
            buttoncopy.Text = "копировать";
            buttoncopy.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { вставитьToolStripMenuItem });
            menuStrip2.Location = new Point(3, 93);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(75, 24);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuStrip2";
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вставитьToolStripMenuItem1, вставитьИзToolStripMenuItem });
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.Size = new Size(67, 20);
            вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // вставитьToolStripMenuItem1
            // 
            вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            вставитьToolStripMenuItem1.Size = new Size(136, 22);
            вставитьToolStripMenuItem1.Text = "вставить ";
            // 
            // вставитьИзToolStripMenuItem
            // 
            вставитьИзToolStripMenuItem.Name = "вставитьИзToolStripMenuItem";
            вставитьИзToolStripMenuItem.Size = new Size(136, 22);
            вставитьИзToolStripMenuItem.Text = "вставить из";
            // 
            // buttoncut
            // 
            buttoncut.BackColor = Color.SeaShell;
            buttoncut.Location = new Point(115, 12);
            buttoncut.Name = "buttoncut";
            buttoncut.Size = new Size(71, 23);
            buttoncut.TabIndex = 4;
            buttoncut.Text = "вырезать";
            buttoncut.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1085, 24);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // frmPaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 450);
            Controls.Add(groupBox2);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(pctpaint);
            MainMenuStrip = menuStrip1;
            Name = "frmPaint";
            Text = "Paint";
            Load += frmPaint_Load;
            ((System.ComponentModel.ISupportInitialize)pctpaint).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private PictureBox pctpaint;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private StatusStrip statusStrip1;
        private GroupBox groupBox5;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button buttonBlue;
        private Button buttonRed;
        private Button button8;
        private Button button9;
        private Button buttonBlack;
        private Button button3;
        private GroupBox groupBox3;
        private PictureBox pictureBox11;
        private PictureBox pictureBox14;
        private PictureBox pictureBox9;
        private PictureBox pictureBox13;
        private PictureBox pictureBox10;
        private PictureBox pictureBox12;
        private GroupBox groupBox4;
        private PictureBox pictureBox15;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem1;
        private ToolStripMenuItem вставитьИзToolStripMenuItem;
        private Button buttoncut;
        private Button buttoncopy;
        private MenuStrip menuStrip1;
    }
}