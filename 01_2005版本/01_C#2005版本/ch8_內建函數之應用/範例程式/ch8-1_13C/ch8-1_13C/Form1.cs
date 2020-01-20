using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch8_1_13C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         string D1, D2="", D3;
         int i;
         D1 = textBox1.Text;
         D3 = D1;
         for(i =D1.Length-1;i>=0;i--)
         D2 = D2 + D1.Substring(i,1);          //代表一次取一個字元
         if(D2 == D3)
           MessageBox.Show(D3 + " 是迴文.");
         else
           MessageBox.Show(D3 + " 不是迴文.");
        }
    }
}