using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientifiCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declaring variables
        decimal Num1, Num2;
        decimal Rand;
        string Operation;

        //Method to keep data in the textbox
        private void input(string a)
        {
            if (txtDsp.Text == "0")

                txtDsp.Text = a;
            else
                txtDsp.Text += a;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            input("0");
        }

        private void b1_Click(object sender, EventArgs e)
        {
            input("1");
        }

        private void b2_Click(object sender, EventArgs e)
        {
            input("2");
        }

        private void b3_Click(object sender, EventArgs e)
        {
            input("3");
        }

        private void b4_Click(object sender, EventArgs e)
        {
            input("4");
        }

        private void b5_Click(object sender, EventArgs e)
        {
            input("5");
        }

        private void b6_Click(object sender, EventArgs e)
        {
            input("6");
        }

        private void b7_Click(object sender, EventArgs e)
        {
            input("7");
        }

        private void b8_Click(object sender, EventArgs e)
        {
            input("8");
        }

        private void b9_Click(object sender, EventArgs e)
        {
            input("9");
        }

        private void bdv_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtDsp.Text);
            Operation = "/";
            txtDsp.Text = "0";
        }

        private void bx_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtDsp.Text);
            Operation = "x";
            txtDsp.Text = "0";
        }

        private void bmin_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtDsp.Text);
            Operation = "-";
            txtDsp.Text = "0";
        }

        private void bpls_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtDsp.Text);
            Operation = "+";
            txtDsp.Text = "0";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            txtDsp.Text = "";
        }

        private void bsin_Click(object sender, EventArgs e)
        {

        }

        private void bcops_Click(object sender, EventArgs e)
        {

        }

        private void bMod_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtDsp.Text);
            Operation = "%";
            txtDsp.Text = "0";
        }

        private void bSqr_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtDsp.Text);
            Operation = "^";
            txtDsp.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEro_Click(object sender, EventArgs e)
        {
            Num1 = 21 * decimal.Parse(txtDsp.Text);
            txtDsp.Text = (Num1.ToString());
        }

        private void btnPnd_Click(object sender, EventArgs e)
        {
            Num1 = 16 * decimal.Parse(txtDsp.Text);
            txtDsp.Text = (Num1.ToString());
        }

        private void btnDlr_Click(object sender, EventArgs e)
        {
            Num1 = 11 * decimal.Parse(txtDsp.Text);
            txtDsp.Text = (Num1.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRnd_Click(object sender, EventArgs e)
        {
            Num1 = 1* decimal.Parse(txtDsp.Text);
            Operation = "R";
            txtDsp.Text = (Num1.ToString());
        }

        private void btnCvt_Click(object sender, EventArgs e)
        {

            Num1 = decimal.Parse(txtDsp.Text);
            txtDsp.Text = (Num1.ToString());

        }

        private void btnRnd2_Click(object sender, EventArgs e)
        {
            Num1 = 1/ decimal.Parse(txtDsp.Text);
            txtDsp.Text = (Num1.ToString());
        }

        private void btnEro2_Click(object sender, EventArgs e)
        {
            Num1 =  21/  decimal.Parse(txtDsp.Text);
            txtDsp.Text = (Num1.ToString());
        }

        private void btnPnd2_Click(object sender, EventArgs e)
        {
            Num1 = 16 / decimal.Parse(txtDsp.Text);
            txtDsp.Text = (Num1.ToString());
        }

        private void btnDlr2_Click(object sender, EventArgs e)
        {
            Num1 = 11 / decimal.Parse(txtDsp.Text);
            txtDsp.Text = (Num1.ToString());
        }

        private void beql_Click(object sender, EventArgs e)
        {
            Num2 = decimal.Parse(txtDsp.Text);
            switch (Operation)
            {
                case "+":
                    txtDsp.Text = (Num1 + Num2).ToString();
                    break;
                case "-":
                    txtDsp.Text = (Num1 - Num2).ToString();
                    break;
                case "x":
                    txtDsp.Text = (Num1 * Num2).ToString();
                    break;
                case "/":
                    txtDsp.Text = (Num1 / Num2).ToString();
                    break;
                case "^":
                    txtDsp.Text = (int.Parse(Num1.ToString()) ^ int.Parse(Num2.ToString())).ToString();
                       
                    break;
                case "%":
                    txtDsp.Text = (Num1 % Num2).ToString();
                    break;

            }
        }
    }
}
