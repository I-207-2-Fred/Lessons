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
            this.pctpaint = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьИзToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttoncut = new System.Windows.Forms.Button();
            this.buttoncopy = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pctpaint)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctpaint
            // 
            this.pctpaint.Location = new System.Drawing.Point(0, 88);
            this.pctpaint.Name = "pctpaint";
            this.pctpaint.Size = new System.Drawing.Size(800, 362);
            this.pctpaint.TabIndex = 10;
            this.pctpaint.TabStop = false;
            this.pctpaint.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pctpaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctpaint_MouseDown);
            this.pctpaint.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pctpaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctpaint_MouseMove);
            this.pctpaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctpaint_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1085, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.buttonBlue);
            this.groupBox5.Controls.Add(this.buttonRed);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.buttonBlack);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Location = new System.Drawing.Point(768, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(302, 121);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "цвет";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button4.Location = new System.Drawing.Point(260, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 27);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.HotPink;
            this.button5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button5.Location = new System.Drawing.Point(219, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 27);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button6.Location = new System.Drawing.Point(180, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 27);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Lime;
            this.button7.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button7.Location = new System.Drawing.Point(140, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 27);
            this.button7.TabIndex = 4;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBlue.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonBlue.Location = new System.Drawing.Point(260, 17);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(35, 27);
            this.buttonBlue.TabIndex = 3;
            this.buttonBlue.UseVisualStyleBackColor = false;
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonRed.Location = new System.Drawing.Point(221, 15);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(33, 27);
            this.buttonRed.TabIndex = 4;
            this.buttonRed.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(74, 17);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 8;
            this.button8.Text = "цвет 2";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(8, 16);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.TabIndex = 9;
            this.button9.Text = "цвет 2";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBlack.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonBlack.Location = new System.Drawing.Point(181, 14);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(34, 27);
            this.buttonBlack.TabIndex = 5;
            this.buttonBlack.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.Location = new System.Drawing.Point(140, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 27);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.pictureBox11);
            this.groupBox3.Controls.Add(this.pictureBox14);
            this.groupBox3.Controls.Add(this.pictureBox9);
            this.groupBox3.Controls.Add(this.pictureBox13);
            this.groupBox3.Controls.Add(this.pictureBox10);
            this.groupBox3.Controls.Add(this.pictureBox12);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(381, -3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 124);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "инструменты";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(68, 40);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(19, 19);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 15;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(68, 65);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(19, 19);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 18;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(18, 40);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(19, 19);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(43, 65);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(19, 19);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 17;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(43, 41);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(19, 19);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(18, 65);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(19, 19);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 16;
            this.pictureBox12.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.pictureBox15);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(515, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 121);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "фигуры";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(3, 13);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(72, 68);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 19;
            this.pictureBox15.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(192, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "изображения";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.buttoncopy);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.menuStrip2);
            this.groupBox2.Controls.Add(this.buttoncut);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1085, 143);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "буфер обмена";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вставитьToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 93);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(75, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вставитьToolStripMenuItem1,
            this.вставитьИзToolStripMenuItem});
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // вставитьToolStripMenuItem1
            // 
            this.вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            this.вставитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.вставитьToolStripMenuItem1.Text = "вставить ";
            // 
            // вставитьИзToolStripMenuItem
            // 
            this.вставитьИзToolStripMenuItem.Name = "вставитьИзToolStripMenuItem";
            this.вставитьИзToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вставитьИзToolStripMenuItem.Text = "вставить из";
            // 
            // buttoncut
            // 
            this.buttoncut.BackColor = System.Drawing.Color.SeaShell;
            this.buttoncut.Location = new System.Drawing.Point(115, 12);
            this.buttoncut.Name = "buttoncut";
            this.buttoncut.Size = new System.Drawing.Size(71, 23);
            this.buttoncut.TabIndex = 4;
            this.buttoncut.Text = "вырезать";
            this.buttoncut.UseVisualStyleBackColor = false;
            // 
            // buttoncopy
            // 
            this.buttoncopy.BackColor = System.Drawing.Color.SeaShell;
            this.buttoncopy.Location = new System.Drawing.Point(115, 59);
            this.buttoncopy.Name = "buttoncopy";
            this.buttoncopy.Size = new System.Drawing.Size(71, 23);
            this.buttoncopy.TabIndex = 22;
            this.buttoncopy.Text = "копировать";
            this.buttoncopy.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pctpaint);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPaint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.frmPaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctpaint)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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