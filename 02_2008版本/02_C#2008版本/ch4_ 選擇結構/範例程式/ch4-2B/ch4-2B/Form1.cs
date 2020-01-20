using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch4_2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//輸入
            int h = 190;
         //處理及輸出
            if (h > 180)
                MessageBox.Show("哇！好高丫");
            else
                MessageBox.Show("這才比較正常");
        }
    }
}