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
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnprecent = new System.Windows.Forms.Button();
            this.btnsqrt = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnmultiplication = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnzap = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.txtscreen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 144);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(64, 41);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 191);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(64, 41);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 238);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(64, 41);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 285);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(136, 41);
            this.btn0.TabIndex = 6;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(84, 238);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(64, 41);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(84, 191);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(64, 41);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(84, 144);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(64, 41);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(225, 238);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(64, 88);
            this.button14.TabIndex = 18;
            this.button14.Text = "=";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btnActionResult);
            // 
            // btnprecent
            // 
            this.btnprecent.Location = new System.Drawing.Point(12, 97);
            this.btnprecent.Name = "btnprecent";
            this.btnprecent.Size = new System.Drawing.Size(64, 41);
            this.btnprecent.TabIndex = 15;
            this.btnprecent.Text = "%";
            this.btnprecent.UseVisualStyleBackColor = true;
            this.btnprecent.Click += new System.EventHandler(this.btnActionOperation);
            // 
            // btnsqrt
            // 
            this.btnsqrt.Location = new System.Drawing.Point(82, 97);
            this.btnsqrt.Name = "btnsqrt";
            this.btnsqrt.Size = new System.Drawing.Size(64, 41);
            this.btnsqrt.TabIndex = 14;
            this.btnsqrt.Text = "^";
            this.btnsqrt.UseVisualStyleBackColor = true;
            this.btnsqrt.Click += new System.EventHandler(this.btnActionOperation);
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(225, 191);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(64, 41);
            this.btnplus.TabIndex = 24;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnActionOperation);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(225, 144);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(64, 41);
            this.btnminus.TabIndex = 23;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnActionOperation);
            // 
            // btnmultiplication
            // 
            this.btnmultiplication.Location = new System.Drawing.Point(225, 97);
            this.btnmultiplication.Name = "btnmultiplication";
            this.btnmultiplication.Size = new System.Drawing.Size(64, 41);
            this.btnmultiplication.TabIndex = 22;
            this.btnmultiplication.Text = "*";
            this.btnmultiplication.UseVisualStyleBackColor = true;
            this.btnmultiplication.Click += new System.EventHandler(this.btnActionOperation);
            // 
            // btndivision
            // 
            this.btndivision.Location = new System.Drawing.Point(155, 97);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(64, 41);
            this.btndivision.TabIndex = 21;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.btnActionOperation);
            // 
            // btnzap
            // 
            this.btnzap.Location = new System.Drawing.Point(155, 285);
            this.btnzap.Name = "btnzap";
            this.btnzap.Size = new System.Drawing.Size(64, 41);
            this.btnzap.TabIndex = 30;
            this.btnzap.Text = ",";
            this.btnzap.UseVisualStyleBackColor = true;
            this.btnzap.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(155, 238);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(64, 41);
            this.btn3.TabIndex = 29;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(155, 191);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(64, 41);
            this.btn6.TabIndex = 28;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(155, 144);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(64, 41);
            this.btn9.TabIndex = 27;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // txtscreen
            // 
            this.txtscreen.Location = new System.Drawing.Point(12, 12);
            this.txtscreen.Multiline = true;
            this.txtscreen.Name = "txtscreen";
            this.txtscreen.Size = new System.Drawing.Size(277, 79);
            this.txtscreen.TabIndex = 31;
            this.txtscreen.TextChanged += new System.EventHandler(this.txtscreen_TextChanged);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 335);
            this.Controls.Add(this.txtscreen);
            this.Controls.Add(this.btnzap);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnmultiplication);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btnprecent);
            this.Controls.Add(this.btnsqrt);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Name = "frmCalculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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

}
}