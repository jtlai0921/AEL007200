using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch8_1_7
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
            Result = Str1.IndexOf(Str2);
            if (Result != -1)
                MessageBox.Show("摘要中有：" + Str2.ToString() + " 關鍵字");
            else
                MessageBox.Show("摘要中沒有：" + Str2.ToString() + " 關鍵字");
        }

    }
}