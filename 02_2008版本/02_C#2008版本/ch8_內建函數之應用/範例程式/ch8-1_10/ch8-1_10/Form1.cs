using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch8_1_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Str1 = textBox3.Text;
            string Str2 = textBox1.Text;
            string Str3 = textBox2.Text;
            string Result;
            Result = Str1.Replace(Str2,Str3);
            textBox3.Text = Result;
        }
    }
}