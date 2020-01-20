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
        {// ==== ���;�ƶü�====
            TempStr1 = "��l��ơ@�G";
            Random r = new Random();
            for (i = 1; i <= 10; i++)
            {
                A[i] = r.Next(1, 101);  //����1~100����ƶüƭ�
                TempStr1 = TempStr1 + " " + string.Format("{0:D2}", A[i]);
            }
            n = i - 1;
            label1.Text = TempStr1;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {// === �i��Ƨ�===
            SelSort(ref A, n);    //�I�s��ܱƧǪk���Ƶ{��
            TempStr2 = TempStr2 + "�Ƨǫ�ƦC�G";
            for (i = 1; i <= 10; i++)
                TempStr2 = TempStr2 + " " + string.Format("{0:D2}", A[i]);
            label2.Text = TempStr2;
        }
        static void SelSort(ref int[] A, int n)  //��ܱƧǪk���Ƶ{��
        {
            int i, j, Temp, NP = 0;
            for (i = 1; i <= n - 1; i++)
            {
                NP = i;
                for (j = i + 1; j <= n; j++)
                    if (A[j] > A[NP])
                        NP = j;
                {//�۾F��Ӫ���ƥ洫��m
                    Temp = A[i];
                    A[i] = A[NP];
                    A[NP] = Temp;
                }
            }
        }
    }
}