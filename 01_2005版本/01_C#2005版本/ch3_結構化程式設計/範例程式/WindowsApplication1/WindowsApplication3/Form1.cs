using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int C_Score,E_Score, Average;
            C_Score=int.Parse(textBox1.Text);
            E_Score=int.Parse(textBox2.Text);
            Average=(C_Score+E_Score)/2;
            if (Average>=90)
                MessageBox.Show("ヒ单");
            if (Average>=80 & Average<90)
                MessageBox.Show("单");
            if (Average>=70 & Average<80)
                MessageBox.Show("单");
            if (Average>=60 & Average<70)
                MessageBox.Show("单");
            if (Average<60)
                MessageBox.Show("コ单");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Average=100;
            if (Average >= 90)
            {
                MessageBox.Show("ヒ单");
            }
        }
    }
}