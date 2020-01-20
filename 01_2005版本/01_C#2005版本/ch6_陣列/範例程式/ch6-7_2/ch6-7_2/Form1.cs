using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch6_7_2
{
    public partial class Form1 : Form
    {
        string TempStr1, TempStr2;
        int[] A = new int[11];
        int n, i;
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
                A[i] = r.Next(1, 101);  //產生1~100的整數亂數值
                TempStr1 = TempStr1 + " " + string.Format("{0:D2}", A[i]);
            }
            n = i - 1;
            label1.Text = TempStr1;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {// === 進行排序===
            SelSort(ref A, n);    //呼叫選擇排序法的副程式
            TempStr2 = TempStr2 + "排序後數列：";
            for (i = 1; i <= 10; i++)
                TempStr2 = TempStr2 + " " + string.Format("{0:D2}", A[i]);
            label2.Text = TempStr2;
        }
        static void SelSort(ref int[] A, int n)  //選擇排序法之副程式
        {
            int i, j, Temp, NP = 0;
            for (i = 1; i <= n - 1; i++)
            {
                NP = i;
                for (j = i + 1; j <= n; j++)
                    if (A[j] > A[NP])
                        NP = j;
                {//相鄰兩個的資料交換位置
                    Temp = A[i];
                    A[i] = A[NP];
                    A[NP] = Temp;
                }
            }
        }
    }
}