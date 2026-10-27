namespace Leasons
{
    partial class frmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            button14 = new Button();
            btnprecent = new Button();
            btnsqrt = new Button();
            btnplus = new Button();
            btnminus = new Button();
            btnmultiplication = new Button();
            btndivision = new Button();
            btnzap = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            txtscreen = new TextBox();
            clrbtn = new Button();
            deletebtn = new Button();
            SuspendLayout();
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 144);
            btn7.Name = "btn7";
            btn7.Size = new Size(64, 41);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnActionNumber;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 191);
            btn4.Name = "btn4";
            btn4.Size = new Size(64, 41);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnActionNumber;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 238);
            btn1.Name = "btn1";
            btn1.Size = new Size(64, 41);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnActionNumber;
            // 
            // btn0
            // 
            btn0.Location = new Point(12, 285);
            btn0.Name = "btn0";
            btn0.Size = new Size(136, 41);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnActionNumber;
            // 
            // btn2
            // 
            btn2.Location = new Point(84, 238);
            btn2.Name = "btn2";
            btn2.Size = new Size(64, 41);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnActionNumber;
            // 
            // btn5
            // 
            btn5.Location = new Point(84, 191);
            btn5.Name = "btn5";
            btn5.Size = new Size(64, 41);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnActionNumber;
            // 
            // btn8
            // 
            btn8.Location = new Point(84, 144);
            btn8.Name = "btn8";
            btn8.Size = new Size(64, 41);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnActionNumber;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 12F);
            button14.Location = new Point(225, 238);
            button14.Name = "button14";
            button14.Size = new Size(64, 88);
            button14.TabIndex = 17;
            button14.Text = "=";
            button14.UseVisualStyleBackColor = true;
            button14.Click += btnActionResult;
            // 
            // btnprecent
            // 
            btnprecent.Location = new Point(12, 97);
            btnprecent.Name = "btnprecent";
            btnprecent.Size = new Size(64, 41);
            btnprecent.TabIndex = 11;
            btnprecent.Text = "%";
            btnprecent.UseVisualStyleBackColor = true;
            btnprecent.Click += btnActionOperation;
            // 
            // btnsqrt
            // 
            btnsqrt.Location = new Point(82, 97);
            btnsqrt.Name = "btnsqrt";
            btnsqrt.Size = new Size(66, 41);
            btnsqrt.TabIndex = 12;
            btnsqrt.Text = "^";
            btnsqrt.UseVisualStyleBackColor = true;
            btnsqrt.Click += btnActionOperation;
            // 
            // btnplus
            // 
            btnplus.Location = new Point(225, 191);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(64, 41);
            btnplus.TabIndex = 16;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += btnActionOperation;
            // 
            // btnminus
            // 
            btnminus.Location = new Point(225, 144);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(64, 41);
            btnminus.TabIndex = 15;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
            btnminus.Click += btnActionOperation;
            // 
            // btnmultiplication
            // 
            btnmultiplication.Location = new Point(225, 97);
            btnmultiplication.Name = "btnmultiplication";
            btnmultiplication.Size = new Size(64, 41);
            btnmultiplication.TabIndex = 14;
            btnmultiplication.Text = "*";
            btnmultiplication.UseVisualStyleBackColor = true;
            btnmultiplication.Click += btnActionOperation;
            // 
            // btndivision
            // 
            btndivision.Location = new Point(155, 97);
            btndivision.Name = "btndivision";
            btndivision.Size = new Size(64, 41);
            btndivision.TabIndex = 13;
            btndivision.Text = "/";
            btndivision.UseVisualStyleBackColor = true;
            btndivision.Click += btnActionOperation;
            // 
            // btnzap
            // 
            btnzap.Location = new Point(155, 285);
            btnzap.Name = "btnzap";
            btnzap.Size = new Size(64, 41);
            btnzap.TabIndex = 10;
            btnzap.Text = ",";
            btnzap.UseVisualStyleBackColor = true;
            btnzap.Click += btnActionNumber;
            // 
            // btn3
            // 
            btn3.Location = new Point(155, 238);
            btn3.Name = "btn3";
            btn3.Size = new Size(64, 41);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnActionNumber;
            // 
            // btn6
            // 
            btn6.Location = new Point(155, 191);
            btn6.Name = "btn6";
            btn6.Size = new Size(64, 41);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnActionNumber;
            // 
            // btn9
            // 
            btn9.Location = new Point(155, 144);
            btn9.Name = "btn9";
            btn9.Size = new Size(64, 41);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnActionNumber;
            // 
            // txtscreen
            // 
            txtscreen.Location = new Point(12, 12);
            txtscreen.Multiline = true;
            txtscreen.Name = "txtscreen";
            txtscreen.Size = new Size(277, 79);
            txtscreen.TabIndex = 20;
            txtscreen.TextChanged += txtscreen_TextChanged;
            // 
            // clrbtn
            // 
            clrbtn.Location = new Point(12, 332);
            clrbtn.Name = "clrbtn";
            clrbtn.Size = new Size(136, 23);
            clrbtn.TabIndex = 18;
            clrbtn.Text = "AC";
            clrbtn.UseVisualStyleBackColor = true;
            clrbtn.Click += clrbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(155, 332);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(134, 23);
            deletebtn.TabIndex = 19;
            deletebtn.Text = "<--";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 370);
            Controls.Add(deletebtn);
            Controls.Add(clrbtn);
            Controls.Add(txtscreen);
            Controls.Add(btnzap);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btnplus);
            Controls.Add(btnminus);
            Controls.Add(btnmultiplication);
            Controls.Add(btndivision);
            Controls.Add(button14);
            Controls.Add(btnprecent);
            Controls.Add(btnsqrt);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Name = "frmCalculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btn0;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button button14;
        private Button btnprecent;
        private Button btnsqrt;
        private Button btnplus;
        private Button btnminus;
        private Button btnmultiplication;
        private Button btndivision;
        private Button btnzap;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private TextBox txtscreen;
        private Button clrbtn;
        private Button deletebtn;
    }
}