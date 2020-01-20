using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch7_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// ==== 產生整數亂數====
            //宣告
            string TempStr;
            int[] A = new int[11];
            int i;
            TempStr = "原始資料　：";
            //處理
            Random r = new Random();
            for (i = 1; i <= 10; i++)
            {
                A[i] = r.Next(1, 101);  //產生1~100的整數亂數值
                TempStr = TempStr + "   " + string.Format("{0:D2}", A[i]);
            }
            //輸出
            label1.Text = TempStr;
        }
    }
}