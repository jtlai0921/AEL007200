using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch6_8_3
{
    public partial class Form1 : Form
    {
        string TempStr1, TempStr2;
        int[] A = new int[11];
        int n, i, keyword;

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
         int L, H, j, t, M=0, tmp;
         //=== 進行排序(利用氣泡排序法)===
         for(i = 1;i<=9;i++)
            for(j = i + 1;j<=10;j++)
                if(A[i] > A[j])
                {
                   tmp = A[i]; A[i] = A[j]; A[j] = tmp;
                }
         TempStr2 = TempStr2 + "\n";
         TempStr2 = TempStr2 + "排序後數列：" + "\n";
         for(i = 1;i<=10;i++)
         TempStr2 = TempStr2 + "　" + A[i];
         //=== 進行二分搜尋===
         keyword = 100;
         TempStr2 = TempStr2 + "\n";
         TempStr2 = TempStr2 + "===========二分搜尋結果==========" + "\n";
         L = 1; H = 10; t = 0;
     while(L <= H)
      {
         M = (int)((L + H) / 2); 
         t = t + 1;
         if (keyword == A[M])  //判斷欲搜尋的資料是否有在陣列中
         {
           TempStr2 = TempStr2 + "一共找了" + t + " 次，" + keyword + "在排序後的第" + M + "個";
           break;
         }
         if(keyword < A[M])
           H = M - 1;
         else
           L = M + 1;
      }
        label2.Text = TempStr2;
        if(keyword != A[M])
         MessageBox.Show("找不到" + keyword);
   }
 }
}