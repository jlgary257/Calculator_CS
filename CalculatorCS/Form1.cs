using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorCS
{
    public partial class calculator : Form
    {
        double total1 = 0;
        double total2 = 0;
        bool plusButtonClicked = true;
        bool minusButtonClicked = false;
        bool multiButtonClicked = false;
        bool divideButtonClicked = false;
        public calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            plusButtonClicked = true;
            minusButtonClicked = false;
            multiButtonClicked = false;
            divideButtonClicked = false;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(plusButtonClicked == true)
            { total2 = total1 + double.Parse(txtDisplay.Text); 
            } else if(minusButtonClicked == true)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            } else if(multiButtonClicked == true)
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }
            else if(divideButtonClicked == true)
            {
                total2 = total1 / double.Parse(txtDisplay.Text);
            }
            txtDisplay.Text = total2.ToString();
            total1 = 0;

        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiButtonClicked = false;
            divideButtonClicked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiButtonClicked = true;
            divideButtonClicked = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiButtonClicked = false;
            divideButtonClicked = true;
        }
    }
}
