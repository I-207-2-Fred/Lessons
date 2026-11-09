namespace WindowsFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ListViewGroup listViewGroup2 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "" }, -1, Color.Empty, SystemColors.HotTrack, null);
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохронитьToolStripMenuItem = new ToolStripMenuItem();
            сохронитьКакToolStripMenuItem = new ToolStripMenuItem();
            изображенияФорматаToolStripMenuItem = new ToolStripMenuItem();
            изображенияВФорматеGIFToolStripMenuItem = new ToolStripMenuItem();
            печятьToolStripMenuItem = new ToolStripMenuItem();
            печятьToolStripMenuItem1 = new ToolStripMenuItem();
            форматСтранициToolStripMenuItem = new ToolStripMenuItem();
            главноеToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            groupBox5 = new GroupBox();
            btnBrownColor = new Button();
            btnPinkColor = new Button();
            btnPurpleColor = new Button();
            btnGreenColor = new Button();
            btnBluColor = new Button();
            btnRedColor = new Button();
            btnTwoColor = new Button();
            btnOneColor = new Button();
            btnBlackColor = new Button();
            btnWhiteColor = new Button();
            btnCopy = new Button();
            groupBox2 = new GroupBox();
            button18 = new Button();
            groupBox3 = new GroupBox();
            btnGlass = new Button();
            imageList1 = new ImageList(components);
            btnPipette = new Button();
            btnEraser = new Button();
            btnLetter = new Button();
            btnFilling = new Button();
            btnPencil = new Button();
            groupBox4 = new GroupBox();
            btnBrush = new Button();
            listView1 = new ListView();
            groupBox1 = new GroupBox();
            button17 = new Button();
            menuStrip3 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            menuStrip5 = new MenuStrip();
            повернутьToolStripMenuItem = new ToolStripMenuItem();
            повернутьНа90ВПравоToolStripMenuItem = new ToolStripMenuItem();
            повернутьНа90ВЛевоToolStripMenuItem = new ToolStripMenuItem();
            повернутьНа180ToolStripMenuItem = new ToolStripMenuItem();
            отобразитьПоВертикалиToolStripMenuItem = new ToolStripMenuItem();
            отобразитьПоГаризонталиToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            menuStrip2 = new MenuStrip();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem1 = new ToolStripMenuItem();
            вставитьИзToolStripMenuItem = new ToolStripMenuItem();
            btnCut = new Button();
            pictureBox1 = new PictureBox();
            imageList4 = new ImageList(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip3.SuspendLayout();
            menuStrip5.SuspendLayout();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, главноеToolStripMenuItem, видToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1033, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, сохронитьToolStripMenuItem, сохронитьКакToolStripMenuItem, печятьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(155, 22);
            создатьToolStripMenuItem.Text = "создать";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(155, 22);
            открытьToolStripMenuItem.Text = "открыть ";
            // 
            // сохронитьToolStripMenuItem
            // 
            сохронитьToolStripMenuItem.Name = "сохронитьToolStripMenuItem";
            сохронитьToolStripMenuItem.Size = new Size(155, 22);
            сохронитьToolStripMenuItem.Text = "сохронить";
            // 
            // сохронитьКакToolStripMenuItem
            // 
            сохронитьКакToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { изображенияФорматаToolStripMenuItem, изображенияВФорматеGIFToolStripMenuItem });
            сохронитьКакToolStripMenuItem.Name = "сохронитьКакToolStripMenuItem";
            сохронитьКакToolStripMenuItem.Size = new Size(155, 22);
            сохронитьКакToolStripMenuItem.Text = "сохронить как ";
            // 
            // изображенияФорматаToolStripMenuItem
            // 
            изображенияФорматаToolStripMenuItem.Name = "изображенияФорматаToolStripMenuItem";
            изображенияФорматаToolStripMenuItem.Size = new Size(231, 22);
            изображенияФорматаToolStripMenuItem.Text = "изображения формата PNG ";
            // 
            // изображенияВФорматеGIFToolStripMenuItem
            // 
            изображенияВФорматеGIFToolStripMenuItem.Name = "изображенияВФорматеGIFToolStripMenuItem";
            изображенияВФорматеGIFToolStripMenuItem.Size = new Size(231, 22);
            изображенияВФорматеGIFToolStripMenuItem.Text = "Изображения в формате GIF";
            // 
            // печятьToolStripMenuItem
            // 
            печятьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { печятьToolStripMenuItem1, форматСтранициToolStripMenuItem });
            печятьToolStripMenuItem.Name = "печятьToolStripMenuItem";
            печятьToolStripMenuItem.Size = new Size(155, 22);
            печятьToolStripMenuItem.Text = "печять";
            // 
            // печятьToolStripMenuItem1
            // 
            печятьToolStripMenuItem1.Name = "печятьToolStripMenuItem1";
            печятьToolStripMenuItem1.Size = new Size(175, 22);
            печятьToolStripMenuItem1.Text = "печять ";
            // 
            // форматСтранициToolStripMenuItem
            // 
            форматСтранициToolStripMenuItem.Name = "форматСтранициToolStripMenuItem";
            форматСтранициToolStripMenuItem.Size = new Size(175, 22);
            форматСтранициToolStripMenuItem.Text = "формат страници ";
            // 
            // главноеToolStripMenuItem
            // 
            главноеToolStripMenuItem.Name = "главноеToolStripMenuItem";
            главноеToolStripMenuItem.Size = new Size(64, 20);
            главноеToolStripMenuItem.Text = "Главное";
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(39, 20);
            видToolStripMenuItem.Text = "Вид";
            видToolStripMenuItem.Click += видToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(btnCopy);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 124);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnBrownColor);
            groupBox5.Controls.Add(btnPinkColor);
            groupBox5.Controls.Add(btnPurpleColor);
            groupBox5.Controls.Add(btnGreenColor);
            groupBox5.Controls.Add(btnBluColor);
            groupBox5.Controls.Add(btnRedColor);
            groupBox5.Controls.Add(btnTwoColor);
            groupBox5.Controls.Add(btnOneColor);
            groupBox5.Controls.Add(btnBlackColor);
            groupBox5.Controls.Add(btnWhiteColor);
            groupBox5.Location = new Point(728, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(304, 121);
            groupBox5.TabIndex = 19;
            groupBox5.TabStop = false;
            groupBox5.Text = "цвет";
            // 
            // btnBrownColor
            // 
            btnBrownColor.BackColor = Color.Peru;
            btnBrownColor.ForeColor = Color.DarkGoldenrod;
            btnBrownColor.Location = new Point(260, 49);
            btnBrownColor.Name = "btnBrownColor";
            btnBrownColor.Size = new Size(35, 27);
            btnBrownColor.TabIndex = 7;
            btnBrownColor.UseVisualStyleBackColor = false;
            btnBrownColor.Click += ColorButton_Click;
            // 
            // btnPinkColor
            // 
            btnPinkColor.BackColor = Color.HotPink;
            btnPinkColor.ForeColor = Color.DarkGoldenrod;
            btnPinkColor.Location = new Point(219, 49);
            btnPinkColor.Name = "btnPinkColor";
            btnPinkColor.Size = new Size(35, 27);
            btnPinkColor.TabIndex = 4;
            btnPinkColor.UseVisualStyleBackColor = false;
            btnPinkColor.Click += ColorButton_Click;
            // 
            // btnPurpleColor
            // 
            btnPurpleColor.BackColor = Color.FromArgb(64, 0, 64);
            btnPurpleColor.ForeColor = Color.DarkGoldenrod;
            btnPurpleColor.Location = new Point(181, 49);
            btnPurpleColor.Name = "btnPurpleColor";
            btnPurpleColor.Size = new Size(35, 27);
            btnPurpleColor.TabIndex = 4;
            btnPurpleColor.UseVisualStyleBackColor = false;
            btnPurpleColor.Click += ColorButton_Click;
            // 
            // btnGreenColor
            // 
            btnGreenColor.BackColor = Color.Lime;
            btnGreenColor.ForeColor = Color.DarkGoldenrod;
            btnGreenColor.Location = new Point(140, 49);
            btnGreenColor.Name = "btnGreenColor";
            btnGreenColor.Size = new Size(35, 27);
            btnGreenColor.TabIndex = 4;
            btnGreenColor.UseVisualStyleBackColor = false;
            btnGreenColor.Click += ColorButton_Click;
            // 
            // btnBluColor
            // 
            btnBluColor.BackColor = SystemColors.Highlight;
            btnBluColor.ForeColor = Color.DarkGoldenrod;
            btnBluColor.Location = new Point(260, 16);
            btnBluColor.Name = "btnBluColor";
            btnBluColor.Size = new Size(35, 27);
            btnBluColor.TabIndex = 3;
            btnBluColor.UseVisualStyleBackColor = false;
            btnBluColor.Click += ColorButton_Click;
            // 
            // btnRedColor
            // 
            btnRedColor.BackColor = Color.Red;
            btnRedColor.ForeColor = Color.DarkGoldenrod;
            btnRedColor.Location = new Point(221, 16);
            btnRedColor.Name = "btnRedColor";
            btnRedColor.Size = new Size(35, 27);
            btnRedColor.TabIndex = 4;
            btnRedColor.UseVisualStyleBackColor = false;
            btnRedColor.Click += ColorButton_Click;
            // 
            // btnTwoColor
            // 
            btnTwoColor.BackColor = Color.White;
            btnTwoColor.ForeColor = Color.White;
            btnTwoColor.Location = new Point(74, 16);
            btnTwoColor.Name = "btnTwoColor";
            btnTwoColor.Size = new Size(60, 60);
            btnTwoColor.TabIndex = 8;
            btnTwoColor.UseVisualStyleBackColor = false;
            btnTwoColor.Click += ColorButton_Click;
            // 
            // btnOneColor
            // 
            btnOneColor.BackColor = Color.Black;
            btnOneColor.ForeColor = Color.White;
            btnOneColor.Location = new Point(8, 16);
            btnOneColor.Name = "btnOneColor";
            btnOneColor.Size = new Size(60, 60);
            btnOneColor.TabIndex = 9;
            btnOneColor.UseVisualStyleBackColor = false;
            btnOneColor.Click += ColorButton_Click;
            // 
            // btnBlackColor
            // 
            btnBlackColor.BackColor = Color.Black;
            btnBlackColor.ForeColor = Color.DarkGoldenrod;
            btnBlackColor.Location = new Point(181, 16);
            btnBlackColor.Name = "btnBlackColor";
            btnBlackColor.Size = new Size(35, 27);
            btnBlackColor.TabIndex = 5;
            btnBlackColor.UseVisualStyleBackColor = false;
            btnBlackColor.Click += ColorButton_Click;
            // 
            // btnWhiteColor
            // 
            btnWhiteColor.BackColor = Color.White;
            btnWhiteColor.ForeColor = Color.DarkGoldenrod;
            btnWhiteColor.Location = new Point(140, 16);
            btnWhiteColor.Name = "btnWhiteColor";
            btnWhiteColor.Size = new Size(35, 27);
            btnWhiteColor.TabIndex = 6;
            btnWhiteColor.UseVisualStyleBackColor = false;
            btnWhiteColor.Click += ColorButton_Click;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.SeaShell;
            btnCopy.Location = new Point(109, 60);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(80, 23);
            btnCopy.TabIndex = 5;
            btnCopy.Text = "Копировать";
            btnCopy.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(button18);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(menuStrip2);
            groupBox2.Controls.Add(btnCut);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Location = new Point(0, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1032, 144);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "буфер обмена";
            // 
            // button18
            // 
            button18.BackgroundImageLayout = ImageLayout.None;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Image = (Image)resources.GetObject("button18.Image");
            button18.Location = new Point(18, 22);
            button18.Name = "button18";
            button18.RightToLeft = RightToLeft.No;
            button18.Size = new Size(60, 54);
            button18.TabIndex = 8;
            button18.UseMnemonic = false;
            button18.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(btnGlass);
            groupBox3.Controls.Add(btnPipette);
            groupBox3.Controls.Add(btnEraser);
            groupBox3.Controls.Add(btnLetter);
            groupBox3.Controls.Add(btnFilling);
            groupBox3.Controls.Add(btnPencil);
            groupBox3.FlatStyle = FlatStyle.Popup;
            groupBox3.Location = new Point(388, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(103, 121);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "инструменты";
            // 
            // btnGlass
            // 
            btnGlass.BackgroundImageLayout = ImageLayout.None;
            btnGlass.FlatStyle = FlatStyle.Flat;
            btnGlass.ImageIndex = 5;
            btnGlass.ImageList = imageList1;
            btnGlass.Location = new Point(71, 54);
            btnGlass.Name = "btnGlass";
            btnGlass.RightToLeft = RightToLeft.No;
            btnGlass.Size = new Size(26, 26);
            btnGlass.TabIndex = 5;
            btnGlass.UseMnemonic = false;
            btnGlass.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-карандаш-48.png");
            imageList1.Images.SetKeyName(1, "icons8-пипетка-50.png");
            imageList1.Images.SetKeyName(2, "icons8-ластик-64.png");
            imageList1.Images.SetKeyName(3, "icons8-a-48.png");
            imageList1.Images.SetKeyName(4, "zalivka.png");
            imageList1.Images.SetKeyName(5, "icons8-увеличительное-стекло-наклонено-влево-emoji-96.png");
            imageList1.Images.SetKeyName(6, "icons8-кисть-50.png");
            // 
            // btnPipette
            // 
            btnPipette.BackgroundImageLayout = ImageLayout.None;
            btnPipette.FlatStyle = FlatStyle.Flat;
            btnPipette.ImageIndex = 1;
            btnPipette.ImageList = imageList1;
            btnPipette.Location = new Point(39, 54);
            btnPipette.Name = "btnPipette";
            btnPipette.RightToLeft = RightToLeft.No;
            btnPipette.Size = new Size(26, 26);
            btnPipette.TabIndex = 4;
            btnPipette.UseMnemonic = false;
            btnPipette.UseVisualStyleBackColor = false;
            // 
            // btnEraser
            // 
            btnEraser.BackgroundImageLayout = ImageLayout.None;
            btnEraser.FlatStyle = FlatStyle.Flat;
            btnEraser.ImageIndex = 2;
            btnEraser.ImageList = imageList1;
            btnEraser.Location = new Point(7, 54);
            btnEraser.Name = "btnEraser";
            btnEraser.RightToLeft = RightToLeft.No;
            btnEraser.Size = new Size(26, 26);
            btnEraser.TabIndex = 3;
            btnEraser.UseMnemonic = false;
            btnEraser.UseVisualStyleBackColor = false;
            btnEraser.Click += btnEraser_Click;
            // 
            // btnLetter
            // 
            btnLetter.BackgroundImageLayout = ImageLayout.None;
            btnLetter.FlatStyle = FlatStyle.Flat;
            btnLetter.ImageIndex = 3;
            btnLetter.ImageList = imageList1;
            btnLetter.Location = new Point(71, 22);
            btnLetter.Name = "btnLetter";
            btnLetter.RightToLeft = RightToLeft.No;
            btnLetter.Size = new Size(26, 26);
            btnLetter.TabIndex = 2;
            btnLetter.UseMnemonic = false;
            btnLetter.UseVisualStyleBackColor = false;
            // 
            // btnFilling
            // 
            btnFilling.BackgroundImageLayout = ImageLayout.None;
            btnFilling.FlatStyle = FlatStyle.Flat;
            btnFilling.ImageIndex = 4;
            btnFilling.ImageList = imageList1;
            btnFilling.Location = new Point(39, 22);
            btnFilling.Name = "btnFilling";
            btnFilling.RightToLeft = RightToLeft.No;
            btnFilling.Size = new Size(26, 26);
            btnFilling.TabIndex = 1;
            btnFilling.UseMnemonic = false;
            btnFilling.UseVisualStyleBackColor = false;
            // 
            // btnPencil
            // 
            btnPencil.BackgroundImageLayout = ImageLayout.None;
            btnPencil.FlatStyle = FlatStyle.Flat;
            btnPencil.ImageIndex = 0;
            btnPencil.ImageList = imageList1;
            btnPencil.Location = new Point(7, 22);
            btnPencil.Name = "btnPencil";
            btnPencil.RightToLeft = RightToLeft.No;
            btnPencil.Size = new Size(26, 26);
            btnPencil.TabIndex = 0;
            btnPencil.UseMnemonic = false;
            btnPencil.UseVisualStyleBackColor = false;
            btnPencil.Click += btnPen_Click;
            // 
            // groupBox4
            // 
            groupBox4.AutoSize = true;
            groupBox4.Controls.Add(btnBrush);
            groupBox4.Controls.Add(listView1);
            groupBox4.FlatStyle = FlatStyle.Popup;
            groupBox4.Location = new Point(490, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(237, 121);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "фигуры";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // btnBrush
            // 
            btnBrush.BackgroundImageLayout = ImageLayout.None;
            btnBrush.FlatStyle = FlatStyle.Flat;
            btnBrush.Image = Leasons.Properties.Resources.icons8_кисть_50;
            btnBrush.Location = new Point(7, 19);
            btnBrush.Name = "btnBrush";
            btnBrush.RightToLeft = RightToLeft.No;
            btnBrush.Size = new Size(55, 55);
            btnBrush.TabIndex = 11;
            btnBrush.UseMnemonic = false;
            btnBrush.UseVisualStyleBackColor = false;
            btnBrush.Click += btnBrush_Click;
            // 
            // listView1
            // 
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            listView1.Groups.AddRange(new ListViewGroup[] { listViewGroup2 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView1.Location = new Point(68, 16);
            listView1.Name = "listView1";
            listView1.Size = new Size(161, 64);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(button17);
            groupBox1.Controls.Add(menuStrip3);
            groupBox1.Controls.Add(menuStrip5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(192, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(208, 122);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "изображения";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button17
            // 
            button17.BackgroundImageLayout = ImageLayout.None;
            button17.FlatStyle = FlatStyle.Flat;
            button17.Image = Leasons.Properties.Resources.icons8_квадрат_90_50;
            button17.Location = new Point(9, 22);
            button17.Name = "button17";
            button17.RightToLeft = RightToLeft.No;
            button17.Size = new Size(66, 49);
            button17.TabIndex = 7;
            button17.UseMnemonic = false;
            button17.UseVisualStyleBackColor = false;
            // 
            // menuStrip3
            // 
            menuStrip3.Dock = DockStyle.None;
            menuStrip3.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip3.Location = new Point(5, 79);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(80, 24);
            menuStrip3.TabIndex = 4;
            menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(72, 20);
            toolStripMenuItem1.Text = "Выделить";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(195, 22);
            toolStripMenuItem2.Text = "Прямоугольная обл...";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(195, 22);
            toolStripMenuItem3.Text = "Произвольная обл...";
            // 
            // menuStrip5
            // 
            menuStrip5.Dock = DockStyle.None;
            menuStrip5.Items.AddRange(new ToolStripItem[] { повернутьToolStripMenuItem });
            menuStrip5.Location = new Point(102, 79);
            menuStrip5.Name = "menuStrip5";
            menuStrip5.Size = new Size(86, 24);
            menuStrip5.TabIndex = 3;
            menuStrip5.Text = "menuStrip5";
            // 
            // повернутьToolStripMenuItem
            // 
            повернутьToolStripMenuItem.BackColor = Color.Transparent;
            повернутьToolStripMenuItem.BackgroundImageLayout = ImageLayout.Center;
            повернутьToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            повернутьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { повернутьНа90ВПравоToolStripMenuItem, повернутьНа90ВЛевоToolStripMenuItem, повернутьНа180ToolStripMenuItem, отобразитьПоВертикалиToolStripMenuItem, отобразитьПоГаризонталиToolStripMenuItem });
            повернутьToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            повернутьToolStripMenuItem.Name = "повернутьToolStripMenuItem";
            повернутьToolStripMenuItem.Size = new Size(78, 20);
            повернутьToolStripMenuItem.Text = "Повернуть";
            повернутьToolStripMenuItem.Click += повернутьToolStripMenuItem_Click;
            // 
            // повернутьНа90ВПравоToolStripMenuItem
            // 
            повернутьНа90ВПравоToolStripMenuItem.Name = "повернутьНа90ВПравоToolStripMenuItem";
            повернутьНа90ВПравоToolStripMenuItem.Size = new Size(231, 22);
            повернутьНа90ВПравоToolStripMenuItem.Text = "Повернуть на 90 в право";
            повернутьНа90ВПравоToolStripMenuItem.Click += повернутьНа90ВПравоToolStripMenuItem_Click;
            // 
            // повернутьНа90ВЛевоToolStripMenuItem
            // 
            повернутьНа90ВЛевоToolStripMenuItem.Name = "повернутьНа90ВЛевоToolStripMenuItem";
            повернутьНа90ВЛевоToolStripMenuItem.Size = new Size(231, 22);
            повернутьНа90ВЛевоToolStripMenuItem.Text = "Повернуть на 90 в лево ";
            // 
            // повернутьНа180ToolStripMenuItem
            // 
            повернутьНа180ToolStripMenuItem.Name = "повернутьНа180ToolStripMenuItem";
            повернутьНа180ToolStripMenuItem.Size = new Size(231, 22);
            повернутьНа180ToolStripMenuItem.Text = "Повернуть на 180 ";
            // 
            // отобразитьПоВертикалиToolStripMenuItem
            // 
            отобразитьПоВертикалиToolStripMenuItem.Name = "отобразитьПоВертикалиToolStripMenuItem";
            отобразитьПоВертикалиToolStripMenuItem.Size = new Size(231, 22);
            отобразитьПоВертикалиToolStripMenuItem.Text = "Отобразить по вертикали ";
            отобразитьПоВертикалиToolStripMenuItem.Click += отобразитьПоВертикалиToolStripMenuItem_Click;
            // 
            // отобразитьПоГаризонталиToolStripMenuItem
            // 
            отобразитьПоГаризонталиToolStripMenuItem.Name = "отобразитьПоГаризонталиToolStripMenuItem";
            отобразитьПоГаризонталиToolStripMenuItem.Size = new Size(231, 22);
            отобразитьПоГаризонталиToolStripMenuItem.Text = "Отобразить по горизонтали ";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(102, 12);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 8;
            button1.Text = "Обрезать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(102, 37);
            button2.Name = "button2";
            button2.Size = new Size(86, 39);
            button2.TabIndex = 10;
            button2.Text = "Измененить размер";
            button2.UseVisualStyleBackColor = false;
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { вставитьToolStripMenuItem });
            menuStrip2.Location = new Point(13, 83);
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
            вставитьToolStripMenuItem1.Size = new Size(137, 22);
            вставитьToolStripMenuItem1.Text = "Вставить ";
            вставитьToolStripMenuItem1.Click += btnPaste;
            // 
            // вставитьИзToolStripMenuItem
            // 
            вставитьИзToolStripMenuItem.Name = "вставитьИзToolStripMenuItem";
            вставитьИзToolStripMenuItem.Size = new Size(137, 22);
            вставитьИзToolStripMenuItem.Text = "Вставить из";
            вставитьИзToolStripMenuItem.Click += btnPasteFrom;
            // 
            // btnCut
            // 
            btnCut.BackColor = Color.SeaShell;
            btnCut.Location = new Point(106, 20);
            btnCut.Name = "btnCut";
            btnCut.Size = new Size(80, 23);
            btnCut.TabIndex = 4;
            btnCut.Text = "Вырезать";
            btnCut.UseVisualStyleBackColor = false;
            btnCut.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1033, 380);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // imageList4
            // 
            imageList4.ColorDepth = ColorDepth.Depth8Bit;
            imageList4.ImageStream = (ImageListStreamer)resources.GetObject("imageList4.ImageStream");
            imageList4.TransparentColor = Color.Transparent;
            imageList4.Images.SetKeyName(0, "icons8-блокнот-50.png");
            imageList4.Images.SetKeyName(1, "icons8-квадрат-90-50.png");
            imageList4.Images.SetKeyName(2, "icons8-кисть-50.png");
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1033, 527);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Paint";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            menuStrip5.ResumeLayout(false);
            menuStrip5.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem повернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повернутьНа90ВПравоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повернутьНа90ВЛевоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повернутьНа180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьПоВертикалиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьПоГаризонталиToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитьИзToolStripMenuItem;
        private System.Windows.Forms.Button btnCut;
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
        private Button button18;
        private Button btnBrush;
        private Button button17;
        private ImageList imageList4;
    }
}

