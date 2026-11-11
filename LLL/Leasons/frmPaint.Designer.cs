namespace WindowsFormsApp1
{
    partial class frmPaint
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaint));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохронитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохронитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изображенияФорматаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изображенияВФорматеGIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печятьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печятьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.форматСтранициToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.повернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGlass = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPipette = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnLetter = new System.Windows.Forms.Button();
            this.btnFilling = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkFilling = new System.Windows.Forms.CheckBox();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.овалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямыйТреугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBrush = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBrownColor = new System.Windows.Forms.Button();
            this.btnPinkColor = new System.Windows.Forms.Button();
            this.btnPurpleColor = new System.Windows.Forms.Button();
            this.btnGreenColor = new System.Windows.Forms.Button();
            this.btnBluColor = new System.Windows.Forms.Button();
            this.btnRedColor = new System.Windows.Forms.Button();
            this.btnTwoColor = new System.Windows.Forms.Button();
            this.btnOneColor = new System.Windows.Forms.Button();
            this.btnBlackColor = new System.Windows.Forms.Button();
            this.btnWhiteColor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.главноеToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохронитьToolStripMenuItem,
            this.сохронитьКакToolStripMenuItem,
            this.печятьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.создатьToolStripMenuItem.Text = "Cоздать";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.открытьToolStripMenuItem.Text = "Открыть ";
            // 
            // сохронитьToolStripMenuItem
            // 
            this.сохронитьToolStripMenuItem.Name = "сохронитьToolStripMenuItem";
            this.сохронитьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохронитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохронитьКакToolStripMenuItem
            // 
            this.сохронитьКакToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изображенияФорматаToolStripMenuItem,
            this.изображенияВФорматеGIFToolStripMenuItem});
            this.сохронитьКакToolStripMenuItem.Name = "сохронитьКакToolStripMenuItem";
            this.сохронитьКакToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохронитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // изображенияФорматаToolStripMenuItem
            // 
            this.изображенияФорматаToolStripMenuItem.Name = "изображенияФорматаToolStripMenuItem";
            this.изображенияФорматаToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.изображенияФорматаToolStripMenuItem.Text = "изображения формата PNG ";
            // 
            // изображенияВФорматеGIFToolStripMenuItem
            // 
            this.изображенияВФорматеGIFToolStripMenuItem.Name = "изображенияВФорматеGIFToolStripMenuItem";
            this.изображенияВФорматеGIFToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.изображенияВФорматеGIFToolStripMenuItem.Text = "Изображения в формате GIF";
            // 
            // печятьToolStripMenuItem
            // 
            this.печятьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.печятьToolStripMenuItem1,
            this.форматСтранициToolStripMenuItem});
            this.печятьToolStripMenuItem.Name = "печятьToolStripMenuItem";
            this.печятьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.печятьToolStripMenuItem.Text = "Печать";
            // 
            // печятьToolStripMenuItem1
            // 
            this.печятьToolStripMenuItem1.Name = "печятьToolStripMenuItem1";
            this.печятьToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.печятьToolStripMenuItem1.Text = "печять ";
            // 
            // форматСтранициToolStripMenuItem
            // 
            this.форматСтранициToolStripMenuItem.Name = "форматСтранициToolStripMenuItem";
            this.форматСтранициToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.форматСтранициToolStripMenuItem.Text = "формат страници ";
            // 
            // главноеToolStripMenuItem
            // 
            this.главноеToolStripMenuItem.Name = "главноеToolStripMenuItem";
            this.главноеToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.главноеToolStripMenuItem.Text = "Главное";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 97);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Очистить";
            // 
            // menuStrip5
            // 
            this.menuStrip5.AutoSize = false;
            this.menuStrip5.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip5.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.повернутьToolStripMenuItem});
            this.menuStrip5.Location = new System.Drawing.Point(6, 26);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(80, 40);
            this.menuStrip5.TabIndex = 3;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // повернутьToolStripMenuItem
            // 
            this.повернутьToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.повернутьToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.повернутьToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.повернутьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.повернутьToolStripMenuItem.Name = "повернутьToolStripMenuItem";
            this.повернутьToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.повернутьToolStripMenuItem.Text = "Очистить";
            this.повернутьToolStripMenuItem.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGlass);
            this.groupBox3.Controls.Add(this.btnPipette);
            this.groupBox3.Controls.Add(this.btnEraser);
            this.groupBox3.Controls.Add(this.btnLetter);
            this.groupBox3.Controls.Add(this.btnFilling);
            this.groupBox3.Controls.Add(this.btnPencil);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(97, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 94);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Инструменты";
            // 
            // btnGlass
            // 
            this.btnGlass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGlass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlass.ImageIndex = 5;
            this.btnGlass.ImageList = this.imageList1;
            this.btnGlass.Location = new System.Drawing.Point(71, 54);
            this.btnGlass.Name = "btnGlass";
            this.btnGlass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGlass.Size = new System.Drawing.Size(26, 26);
            this.btnGlass.TabIndex = 5;
            this.btnGlass.UseMnemonic = false;
            this.btnGlass.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-карандаш-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-пипетка-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-ластик-64.png");
            this.imageList1.Images.SetKeyName(3, "icons8-a-48.png");
            this.imageList1.Images.SetKeyName(4, "zalivka.png");
            this.imageList1.Images.SetKeyName(5, "icons8-увеличительное-стекло-наклонено-влево-emoji-96.png");
            this.imageList1.Images.SetKeyName(6, "icons8-кисть-50.png");
            // 
            // btnPipette
            // 
            this.btnPipette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPipette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPipette.ImageIndex = 1;
            this.btnPipette.ImageList = this.imageList1;
            this.btnPipette.Location = new System.Drawing.Point(39, 54);
            this.btnPipette.Name = "btnPipette";
            this.btnPipette.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPipette.Size = new System.Drawing.Size(26, 26);
            this.btnPipette.TabIndex = 4;
            this.btnPipette.UseMnemonic = false;
            this.btnPipette.UseVisualStyleBackColor = false;
            // 
            // btnEraser
            // 
            this.btnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.ImageIndex = 2;
            this.btnEraser.ImageList = this.imageList1;
            this.btnEraser.Location = new System.Drawing.Point(7, 54);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEraser.Size = new System.Drawing.Size(26, 26);
            this.btnEraser.TabIndex = 3;
            this.btnEraser.UseMnemonic = false;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnLetter
            // 
            this.btnLetter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter.ImageIndex = 3;
            this.btnLetter.ImageList = this.imageList1;
            this.btnLetter.Location = new System.Drawing.Point(71, 22);
            this.btnLetter.Name = "btnLetter";
            this.btnLetter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLetter.Size = new System.Drawing.Size(26, 26);
            this.btnLetter.TabIndex = 2;
            this.btnLetter.UseMnemonic = false;
            this.btnLetter.UseVisualStyleBackColor = false;
            // 
            // btnFilling
            // 
            this.btnFilling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilling.ImageIndex = 4;
            this.btnFilling.ImageList = this.imageList1;
            this.btnFilling.Location = new System.Drawing.Point(39, 22);
            this.btnFilling.Name = "btnFilling";
            this.btnFilling.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFilling.Size = new System.Drawing.Size(26, 26);
            this.btnFilling.TabIndex = 1;
            this.btnFilling.UseMnemonic = false;
            this.btnFilling.UseVisualStyleBackColor = false;
            // 
            // btnPencil
            // 
            this.btnPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencil.ImageIndex = 0;
            this.btnPencil.ImageList = this.imageList1;
            this.btnPencil.Location = new System.Drawing.Point(7, 22);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPencil.Size = new System.Drawing.Size(26, 26);
            this.btnPencil.TabIndex = 0;
            this.btnPencil.UseMnemonic = false;
            this.btnPencil.UseVisualStyleBackColor = false;
            this.btnPencil.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkFilling);
            this.groupBox4.Controls.Add(this.menuStrip3);
            this.groupBox4.Controls.Add(this.btnBrush);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(201, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 94);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Фигуры";
            // 
            // checkFilling
            // 
            this.checkFilling.AutoSize = true;
            this.checkFilling.Location = new System.Drawing.Point(75, 19);
            this.checkFilling.Name = "checkFilling";
            this.checkFilling.Size = new System.Drawing.Size(71, 19);
            this.checkFilling.TabIndex = 12;
            this.checkFilling.Text = "Заливка";
            this.checkFilling.UseVisualStyleBackColor = true;
            this.checkFilling.Click += new System.EventHandler(this.checkFilling_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.AutoSize = false;
            this.menuStrip3.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip3.Location = new System.Drawing.Point(75, 40);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(80, 40);
            this.menuStrip3.TabIndex = 4;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.овалToolStripMenuItem,
            this.линияToolStripMenuItem,
            this.прямыйТреугольникToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 36);
            this.toolStripMenuItem1.Text = "Фигуры";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItem2.Text = "Треугольник";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItem3.Text = "Прямоугольник";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // овалToolStripMenuItem
            // 
            this.овалToolStripMenuItem.Name = "овалToolStripMenuItem";
            this.овалToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.овалToolStripMenuItem.Text = "Овал";
            this.овалToolStripMenuItem.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // линияToolStripMenuItem
            // 
            this.линияToolStripMenuItem.Name = "линияToolStripMenuItem";
            this.линияToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.линияToolStripMenuItem.Text = "Линия";
            this.линияToolStripMenuItem.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // прямыйТреугольникToolStripMenuItem
            // 
            this.прямыйТреугольникToolStripMenuItem.Name = "прямыйТреугольникToolStripMenuItem";
            this.прямыйТреугольникToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.прямыйТреугольникToolStripMenuItem.Text = "Прям-ый треугольник";
            this.прямыйТреугольникToolStripMenuItem.Click += new System.EventHandler(this.btnAngleTriangle_Click);
            // 
            // btnBrush
            // 
            this.btnBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBrush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrush.Image = global::Leasons.Properties.Resources.icons8_кисть_50;
            this.btnBrush.Location = new System.Drawing.Point(7, 19);
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBrush.Size = new System.Drawing.Size(55, 61);
            this.btnBrush.TabIndex = 11;
            this.btnBrush.UseMnemonic = false;
            this.btnBrush.UseVisualStyleBackColor = false;
            this.btnBrush.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.btnBrownColor);
            this.groupBox5.Controls.Add(this.btnPinkColor);
            this.groupBox5.Controls.Add(this.btnPurpleColor);
            this.groupBox5.Controls.Add(this.btnGreenColor);
            this.groupBox5.Controls.Add(this.btnBluColor);
            this.groupBox5.Controls.Add(this.btnRedColor);
            this.groupBox5.Controls.Add(this.btnTwoColor);
            this.groupBox5.Controls.Add(this.btnOneColor);
            this.groupBox5.Controls.Add(this.btnBlackColor);
            this.groupBox5.Controls.Add(this.btnWhiteColor);
            this.groupBox5.Location = new System.Drawing.Point(369, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(382, 94);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Цвет";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Location = new System.Drawing.Point(340, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 27);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Location = new System.Drawing.Point(299, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 27);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.Location = new System.Drawing.Point(340, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 27);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button4.Location = new System.Drawing.Point(301, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 27);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnBrownColor
            // 
            this.btnBrownColor.BackColor = System.Drawing.Color.Peru;
            this.btnBrownColor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBrownColor.Location = new System.Drawing.Point(260, 49);
            this.btnBrownColor.Name = "btnBrownColor";
            this.btnBrownColor.Size = new System.Drawing.Size(35, 27);
            this.btnBrownColor.TabIndex = 7;
            this.btnBrownColor.UseVisualStyleBackColor = false;
            this.btnBrownColor.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // btnPinkColor
            // 
            this.btnPinkColor.BackColor = System.Drawing.Color.HotPink;
            this.btnPinkColor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPinkColor.Location = new System.Drawing.Point(219, 49);
            this.btnPinkColor.Name = "btnPinkColor";
            this.btnPinkColor.Size = new System.Drawing.Size(35, 27);
            this.btnPinkColor.TabIndex = 4;
            this.btnPinkColor.UseVisualStyleBackColor = false;
            this.btnPinkColor.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // btnPurpleColor
            // 
            this.btnPurpleColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPurpleColor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPurpleColor.Location = new System.Drawing.Point(181, 49);
            this.btnPurpleColor.Name = "btnPurpleColor";
            this.btnPurpleColor.Size = new System.Drawing.Size(35, 27);
            this.btnPurpleColor.TabIndex = 4;
            this.btnPurpleColor.UseVisualStyleBackColor = false;
            this.btnPurpleColor.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // btnGreenColor
            // 
            this.btnGreenColor.BackColor = System.Drawing.Color.Lime;
            this.btnGreenColor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGreenColor.Location = new System.Drawing.Point(140, 49);
            this.btnGreenColor.Name = "btnGreenColor";
            this.btnGreenColor.Size = new System.Drawing.Size(35, 27);
            this.btnGreenColor.TabIndex = 4;
            this.btnGreenColor.UseVisualStyleBackColor = false;
            this.btnGreenColor.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // btnBluColor
            // 
            this.btnBluColor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBluColor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBluColor.Location = new System.Drawing.Point(260, 16);
            this.btnBluColor.Name = "btnBluColor";
            this.btnBluColor.Size = new System.Drawing.Size(35, 27);
            this.btnBluColor.TabIndex = 3;
            this.btnBluColor.UseVisualStyleBackColor = false;
            this.btnBluColor.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // btnRedColor
            // 
            this.btnRedColor.BackColor = System.Drawing.Color.Red;
            this.btnRedColor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRedColor.Location = new System.Drawing.Point(221, 16);
            this.btnRedColor.Name = "btnRedColor";
            this.btnRedColor.Size = new System.Drawing.Size(35, 27);
            this.btnRedColor.TabIndex = 4;
            this.btnRedColor.UseVisualStyleBackColor = false;
            this.btnRedColor.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // btnTwoColor
            // 
            this.btnTwoColor.BackColor = System.Drawing.Color.White;
            this.btnTwoColor.ForeColor = System.Drawing.Color.White;
            this.btnTwoColor.Location = new System.Drawing.Point(74, 16);
            this.btnTwoColor.Name = "btnTwoColor";
            this.btnTwoColor.Size = new System.Drawing.Size(60, 60);
            this.btnTwoColor.TabIndex = 8;
            this.btnTwoColor.UseVisualStyleBackColor = false;
            this.btnTwoColor.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // btnOneColor
            // 
            this.btnOneColor.BackColor = System.Drawing.Color.Black;
            this.btnOneColor.ForeColor = System.Drawing.Color.White;
            this.btnOneColor.Location = new System.Drawing.Point(8, 16);
            this.btnOneColor.Name = "btnOneColor";
            this.btnOneColor.Size = new System.Drawing.Size(60, 60);
            this.btnOneColor.TabIndex = 9;
            this.btnOneColor.UseVisualStyleBackColor = false;
            this.btnOneColor.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // btnBlackColor
            // 
            this.btnBlackColor.BackColor = System.Drawing.Color.Black;
            this.btnBlackColor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBlackColor.Location = new System.Drawing.Point(181, 16);
            this.btnBlackColor.Name = "btnBlackColor";
            this.btnBlackColor.Size = new System.Drawing.Size(35, 27);
            this.btnBlackColor.TabIndex = 5;
            this.btnBlackColor.UseVisualStyleBackColor = false;
            this.btnBlackColor.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // btnWhiteColor
            // 
            this.btnWhiteColor.BackColor = System.Drawing.Color.Yellow;
            this.btnWhiteColor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnWhiteColor.Location = new System.Drawing.Point(140, 16);
            this.btnWhiteColor.Name = "btnWhiteColor";
            this.btnWhiteColor.Size = new System.Drawing.Size(35, 27);
            this.btnWhiteColor.TabIndex = 6;
            this.btnWhiteColor.UseVisualStyleBackColor = false;
            this.btnWhiteColor.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(752, 380);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // imageList4
            // 
            this.imageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList4.ImageStream")));
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList4.Images.SetKeyName(0, "icons8-блокнот-50.png");
            this.imageList4.Images.SetKeyName(1, "icons8-квадрат-90-50.png");
            this.imageList4.Images.SetKeyName(2, "icons8-кисть-50.png");
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "Выбор нового элемента";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(80, 40);
            this.miniToolStrip.TabIndex = 3;
            // 
            // frmPaint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(752, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPaint";
            this.Text = "Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохронитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохронитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изображенияФорматаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изображенияВФорматеGIFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печятьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печятьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem форматСтранициToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBluColor;
        private System.Windows.Forms.Button btnRedColor;
        private System.Windows.Forms.Button btnBlackColor;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOneColor;
        private System.Windows.Forms.Button btnTwoColor;
        private System.Windows.Forms.Button btnGreenColor;
        private System.Windows.Forms.Button btnPurpleColor;
        private System.Windows.Forms.Button btnPinkColor;
        private System.Windows.Forms.Button btnBrownColor;
        private System.Windows.Forms.Button btnWhiteColor;
        private System.Windows.Forms.GroupBox groupBox5;
        private Button btnPencil;
        private Button btnGlass;
        private ImageList imageList1;
        private Button btnPipette;
        private Button btnEraser;
        private Button btnLetter;
        private Button btnFilling;
        private Button btnBrush;
        private ImageList imageList4;
        private ToolStripMenuItem овалToolStripMenuItem;
        private ToolStripMenuItem линияToolStripMenuItem;
        private ToolStripMenuItem прямыйТреугольникToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private MenuStrip menuStrip5;
        private ToolStripMenuItem повернутьToolStripMenuItem;
        private MenuStrip miniToolStrip;
        private CheckBox checkFilling;
    }
}

