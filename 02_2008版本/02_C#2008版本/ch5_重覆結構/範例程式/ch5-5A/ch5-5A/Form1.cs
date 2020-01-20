using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch5_5A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //for迴圈
            int i, sum = 0;
            //處理
            for (i = 1; i <= 10; i++)
                sum = sum + i;
            //輸出
            MessageBox.Show("1+2+3+...+10=" + sum);
        }

        private void button2_Click(object sender, EventArgs e)
        {   //while迴圈
            int i=1, sum = 0;
            //處理
            while (i <= 10)
            {
                sum = sum + i;
                i += 1;
            }//輸出
            MessageBox.Show("1+2+3+...+10=" + sum);
        }
    }
}