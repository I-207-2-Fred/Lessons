using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Leasons
{
    public partial class frmCalculator : Form
    {
        bool newOperation = true;
        double firstvalue;
        double secondvalue;
        double result = 0.0;
        string operation = "";

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {

        }

        private void txtscreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActionNumber(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (newOperation)
            {
                txtscreen.Clear();
                newOperation = false;
            }
            if(btn.Text == ",")
            {
                var val = txtscreen.Text.IndexOf(',');
                if (val != -1)
                {
                    return;
                }
                if (btn.Text != ",")
                firstvalue = Convert.ToDouble(txtscreen.Text);
            }
            txtscreen.Text += btn.Text;
        }

        private void btnActionResult(object sender, EventArgs e)
        {
                secondvalue = Convert.ToDouble(txtscreen.Text);
                switch (operation)
                {
                    case "+":
                        result = firstvalue + secondvalue;
                    newOperation = true;
                    break;
                    case "-":
                        result = firstvalue - secondvalue;
                    newOperation = true;
                    break;
                    case "*":
                        result = firstvalue * secondvalue;
                    newOperation = true;
                    break;
                    case "/":
                        result = firstvalue / secondvalue;
                    newOperation = true;
                    break;
                    case "^":
                        result = Math.Pow(firstvalue, secondvalue);
                    newOperation = true;
                    break;
                    case "%":
                        result = firstvalue % secondvalue;
                    newOperation = true;
                    break;
                default:
                    break;
                }
            txtscreen.Text = result.ToString();
            }
        private void btnActionOperation(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstvalue = Convert.ToDouble(txtscreen.Text);
            operation = btn.Text;
            newOperation = true;
        }
    }
}