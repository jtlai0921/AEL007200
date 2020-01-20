using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch8_1_12
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
            bool Result;
            Result = Str1.StartsWith(Str2);
            if (Result == true)
                MessageBox.Show("Str1的開頭是Str2！");
            else
                MessageBox.Show("Str1的開頭不是Str2！");
        }
    }
}