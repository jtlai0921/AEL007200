using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch4_2C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //宣告
            int A;
            //輸入及轉換
            A = int.Parse(textBox1.Text);
            //處理及輸出
            if ((A % 2) == 0)
                MessageBox.Show("偶數");
            else
                MessageBox.Show("奇數");
        } 
    }
}