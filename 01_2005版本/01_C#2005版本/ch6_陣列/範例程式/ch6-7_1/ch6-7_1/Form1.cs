using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch6_7_1
{
    public partial class Form1 : Form
    {
     string TempStr1, TempStr2;
     int[] A=new int[11];
     int n, i;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// ==== 產生整數亂數====
        TempStr1 = "原始資料　：";
        Random r = new Random();
        for(i = 1;i<=10;i++)
        {
            A[i] = r.Next(1,101);  //產生1~100的整數亂數值
            TempStr1 = TempStr1 + " " +string.Format("{0:D2}",A[i]);
        }
        n = i - 1;
        label1.Text=TempStr1;
        }

        private void button2_Click(object sender, EventArgs e)
        {// === 進行排序===
         BubSort(ref A, n);    //呼叫氣泡排序法的副程式
         TempStr2 = TempStr2 + "排序後數列：";
         for(i = 1;i<=10;i++)
            TempStr2 = TempStr2 + " " +string.Format("{0:D2}",A[i]);
         label2.Text=TempStr2;
        }

        static void BubSort(ref int[] A, int n)  //氣泡排序法之副程式
        {
            string Tempstr="";
          int i, j, Temp;
          for (i = n; i > 1; i--)
          {
              for (j = 1; j <i; j++)
              {
                  if (A[j] > A[j + 1])  //相鄰兩個的資料交換位置
                  {
                      Temp = A[j];
                      A[j] = A[j+1];
                      A[j+1] = Temp;
                  }
              }
              Tempstr = Tempstr + "第" + i + "次排序結果：";
              Tempstr = Tempstr + A[i] + "\n";
          }
          MessageBox.Show(Tempstr);
        }
    }
}