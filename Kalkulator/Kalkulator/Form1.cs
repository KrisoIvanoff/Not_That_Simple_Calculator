using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            chisla.Text += "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnplus_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            chisla.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            chisla.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            chisla.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            chisla.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            chisla.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            chisla.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            chisla.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            chisla.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            chisla.Text += "0";
        }

        private void btnplus_Click_1(object sender, EventArgs e)
        {
            chisla.Text += "+";
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            chisla.Text += "-";
        }

        private void btnUmnoj_Click(object sender, EventArgs e)
        {
            chisla.Text += "*";
        }

        private void btndelenie_Click(object sender, EventArgs e)
        {
            chisla.Text += "/";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            chisla.Text = String.Empty;
        }

        private void btnravno_Click(object sender, EventArgs e)
        {
            string result = "";
            int ch1 = 0;
            int st = 0;
            int ch2 = 0;
            result = chisla.Text;
            if (chisla.Text != null)
            {
                if (chisla.Text.Contains("+"))
                {
                    st = chisla.Text.IndexOf("+");
                    result = chisla.Text.Replace("+", string.Empty);
                    if (String.Empty != result.Substring(0, st))
                        ch1 = Convert.ToInt32(result.Substring(0, st));
                    if (String.Empty != result.Substring(st))
                        ch2 = Convert.ToInt32(result.Substring(st));
                    int res = ch1 + ch2;
                    chisla.Text = res.ToString();
                }
                else if (chisla.Text.Contains("-"))
                {
                    st = chisla.Text.IndexOf("-");
                    result = chisla.Text.Replace("-", string.Empty);
                    if (String.Empty != result.Substring(0, st))
                        ch1 = Convert.ToInt32(result.Substring(0, st));
                    if (String.Empty != result.Substring(st))
                        ch2 = Convert.ToInt32(result.Substring(st));
                    int res = ch1 - ch2;
                    chisla.Text = res.ToString();
                }
                else if (chisla.Text.Contains("*"))
                {
                    st = chisla.Text.IndexOf("*");
                    result = chisla.Text.Replace("*", string.Empty);
                    if (String.Empty != result.Substring(0, st))
                        ch1 = Convert.ToInt32(result.Substring(0, st));
                    if (String.Empty != result.Substring(st))
                        ch2 = Convert.ToInt32(result.Substring(st));
                    int res = ch1 * ch2;
                    chisla.Text = res.ToString();

                }
                else if (chisla.Text.Contains("/"))
                {
                    st = chisla.Text.IndexOf("/");
                    result = chisla.Text.Replace("/", string.Empty);
                    if (String.Empty != result.Substring(0, st))
                        ch1 = Convert.ToInt32(result.Substring(0, st));
                    if (String.Empty != result.Substring(st))
                        ch2 = Convert.ToInt32(result.Substring(st));
                    int res = ch1 / ch2;
                    chisla.Text = res.ToString();
                }
            }
            else
            {
                MessageBox.Show("String empty");
            }
        }
    }
}