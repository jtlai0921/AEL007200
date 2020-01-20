using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch8_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Str1 = textBox1.Text;
            string Str2 = textBox2.Text;
            int Result;
            Result =Str1.CompareTo(Str2);
            if (Result == 0)
                MessageBox.Show("兩個字串相同！");
            else
                MessageBox.Show("兩個字串不相同！");
        }
    }
}