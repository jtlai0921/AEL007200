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
            string Str1 = textBox1.Text;
            int m = int.Parse(comboBox1.Text)-1;
            int n = int.Parse(comboBox2.Text);
            textBox2.Text = Str1.Substring(m, n);
        }
    }
}