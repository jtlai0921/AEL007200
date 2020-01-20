using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch6_3_2C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //宣告
            string D1, D2 = "", D3;
            int i;
            string[] A = new string[10];
            //輸入
            D1 = textBox1.Text;
            //處理
            D3 = D1;
            for (i = 0; i <= D1.Length - 1; i++)
                A[i] = D1.Substring(i, 1);   //代表一次取一個字元放入陣列中
            for (i = D1.Length - 1; i >= 0; i--)      //從最後一個開始顯示出來
                D2 = D2 + A[i];
            if (D2 == D3)
                MessageBox.Show(D3 + "是迴文");    //輸出
            else
                MessageBox.Show(D3 + "不是迴文");  //輸出
        }
    }
}