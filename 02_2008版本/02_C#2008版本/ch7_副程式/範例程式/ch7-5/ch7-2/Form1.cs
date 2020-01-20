using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch7_5
{
    public partial class Form1 : Form
    {
        int[] A = new int[11];
        string TempStr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string TempStr = "";
            int i;
            Random r = new Random();
            for (i = 1; i <= 10; i++)
            {
                A[i] = r.Next(1, 101);  //產生~100的整數亂數值
            }
            BubSort(ref A, 10);    //呼叫氣泡排序法的副程式
            for (i = 1; i <= 10; i++)
                TempStr = TempStr + "," + A[i];
            textBox1.Text = TempStr;
            textBox1.Text = TempStr.Substring(1, TempStr.Length - 1);
        }
        static void BubSort(ref int[] A, int n)  //氣泡排序法之副程式
        {
            int i, j, Temp;
            for (i = 1; i <= n - 1; i++)
                for (j = i + 1; j <= n; j++)
                    if (A[i] > A[j])
                    {
                        Temp = A[i];
                        A[i] = A[j];
                        A[j] = Temp;
                    }
        }
    }
}