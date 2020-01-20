using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch2_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  //宣告變數
            int i, Sum;
           //處理
            for (i = 1; i <= 10; i++)
                Sum = Sun + 1;
           //輸出
            MessageBox.Show("總數是：" + Sum);
        }
    }
}