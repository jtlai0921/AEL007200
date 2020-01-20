using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch4_4_2A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  //利用if/else
            int Age;
            Age = int.Parse(textBox1.Text);
            if (Age == 0 | Age < 6)
                textBox2.Text = "普通級";
            if (Age == 6 | Age < 12)
                textBox2.Text = "保護級";
            if (Age == 12 | Age < 18)
                textBox2.Text = "輔導級";
            if (Age >= 18)
                textBox2.Text = "限制級";
        }

        private void button2_Click(object sender, EventArgs e)
        {  //利用switch/case
            int Age;
            Age = int.Parse(textBox1.Text);
            switch ((int)(Age / 6))
            {
                case 0:
                    textBox2.Text = "普通級";
                    break;
                case 1:
                    textBox2.Text = "保護級";
                    break;
                case 2:
                    textBox2.Text = "輔導級";
                    break;
                default:
                    textBox2.Text = "限制級";
                    break;
            }
        }
    }
}