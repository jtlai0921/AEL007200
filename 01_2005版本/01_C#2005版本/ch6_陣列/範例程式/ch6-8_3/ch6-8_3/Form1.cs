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
        {// ==== ���;�ƶü�====
            TempStr1 = "��l��ơ@�G";
            Random r = new Random();
            for (i = 1; i <= 10; i++)
            {
                A[i] = r.Next(1, 101);  //����~100����ƶüƭ�
                TempStr1 = TempStr1 + " " + string.Format("{0:D2}", A[i]);
            }
            n = i - 1;
            label1.Text = TempStr1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
         int L, H, j, t, M=0, tmp;
         //=== �i��Ƨ�(�Q�ή�w�ƧǪk)===
         for(i = 1;i<=9;i++)
            for(j = i + 1;j<=10;j++)
                if(A[i] > A[j])
                {
                   tmp = A[i]; A[i] = A[j]; A[j] = tmp;
                }
         TempStr2 = TempStr2 + "\n";
         TempStr2 = TempStr2 + "�Ƨǫ�ƦC�G" + "\n";
         for(i = 1;i<=10;i++)
         TempStr2 = TempStr2 + "�@" + A[i];
         //=== �i��G���j�M===
         keyword = 100;
         TempStr2 = TempStr2 + "\n";
         TempStr2 = TempStr2 + "===========�G���j�M���G==========" + "\n";
         L = 1; H = 10; t = 0;
     while(L <= H)
      {
         M = (int)((L + H) / 2); 
         t = t + 1;
         if (keyword == A[M])  //�P�_���j�M����ƬO�_���b�}�C��
         {
           TempStr2 = TempStr2 + "�@�@��F" + t + " ���A" + keyword + "�b�Ƨǫ᪺��" + M + "��";
           break;
         }
         if(keyword < A[M])
           H = M - 1;
         else
           L = M + 1;
      }
        label2.Text = TempStr2;
        if(keyword != A[M])
         MessageBox.Show("�䤣��" + keyword);
   }
 }
}