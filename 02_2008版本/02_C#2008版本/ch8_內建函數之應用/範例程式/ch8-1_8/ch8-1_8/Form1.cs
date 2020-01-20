using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch8_1_8
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
            string Result;
            Result = Str1.Insert(Str1.Length,Str2);
            textBox3.Text = Result;
        }
    }
}