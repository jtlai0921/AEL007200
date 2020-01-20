using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch8_1_11
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
            char Str2 =char.Parse(textBox2.Text);
            string[] Result = Str1.Split(Str2);
            textBox3.Text = Result[0] + "¦~" + Result[1] + "¤ë" + Result[2] + "¤é";
        }
    }
}