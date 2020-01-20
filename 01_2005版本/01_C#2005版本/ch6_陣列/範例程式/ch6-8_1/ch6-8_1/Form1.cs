using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch6_8_1
{
    public partial class Form1 : Form
    {
        string TempStr1, TempStr2;
        int[] A = new int[11];
        int n, i,c,keyword;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// ==== 產生整數亂數====
            TempStr1 = "原始資料　：";
            Random r = new Random();
            for (i = 1; i <= 10; i++)
            {
                A[i] = r.Next(1, 101);  //產生~100的整數亂數值
                TempStr1 = TempStr1 + " " + string.Format("{0:D2}", A[i]);
            }
            n = i - 1;
            label1.Text = TempStr1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          keyword = 100;  //假設欲查詢100
          c = 0;
          TempStr2 = TempStr2 + "\n";
          TempStr2 = TempStr2 + "===========循序搜尋結果==========" + "\n";
          for(i=1;i<=10;i++)
          {
            if (keyword == A[i])  //判斷欲搜尋的資料是否有在陣列中
            {
                TempStr2 = TempStr2 + "共搜尋了" + i + "次，" + keyword + "在亂數數列中的第" + i + " 個";
                c = 1;
                break;
            }
          }
            label2.Text = TempStr2;
            if (c == 0)
                MessageBox.Show("找不到" + keyword);
        }
    }
}