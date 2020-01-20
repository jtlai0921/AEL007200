using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch5_5B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //宣告及初值設定
            int i = 1, sum = 2;
            //處理
            while (sum < 1000)
            {
                sum = sum * 2;
                i += 1;
            }//輸出
            label1.Text="2的" + i + "次方=" + sum;
        }
    }
}