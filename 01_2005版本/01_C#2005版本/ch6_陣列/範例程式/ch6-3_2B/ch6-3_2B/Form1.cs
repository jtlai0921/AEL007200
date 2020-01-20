using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch6_3_2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //宣告
            int[] A = new int[6];
            int i;
            //初值設定
            int sum = 0;
            A[0] = 60; A[1] = 70; A[2] = 80; A[3] = 85; A[4] = 90; A[5] = 100;
            //處理
            for (i = 0; i <= 5; i++)
                sum += A[i];
            //輸出
            MessageBox.Show("平均成績為：" + sum/6);
            MessageBox.Show("總分為：" + sum);
        }
    }
}