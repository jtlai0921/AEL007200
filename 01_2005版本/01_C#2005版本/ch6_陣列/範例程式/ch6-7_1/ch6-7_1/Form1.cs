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
        {// ==== ���;�ƶü�====
        TempStr1 = "��l��ơ@�G";
        Random r = new Random();
        for(i = 1;i<=10;i++)
        {
            A[i] = r.Next(1,101);  //����1~100����ƶüƭ�
            TempStr1 = TempStr1 + " " +string.Format("{0:D2}",A[i]);
        }
        n = i - 1;
        label1.Text=TempStr1;
        }

        private void button2_Click(object sender, EventArgs e)
        {// === �i��Ƨ�===
         BubSort(ref A, n);    //�I�s��w�ƧǪk���Ƶ{��
         TempStr2 = TempStr2 + "�Ƨǫ�ƦC�G";
         for(i = 1;i<=10;i++)
            TempStr2 = TempStr2 + " " +string.Format("{0:D2}",A[i]);
         label2.Text=TempStr2;
        }

        static void BubSort(ref int[] A, int n)  //��w�ƧǪk���Ƶ{��
        {
            string Tempstr="";
          int i, j, Temp;
          for (i = n; i > 1; i--)
          {
              for (j = 1; j <i; j++)
              {
                  if (A[j] > A[j + 1])  //�۾F��Ӫ���ƥ洫��m
                  {
                      Temp = A[j];
                      A[j] = A[j+1];
                      A[j+1] = Temp;
                  }
              }
              Tempstr = Tempstr + "��" + i + "���Ƨǵ��G�G";
              Tempstr = Tempstr + A[i] + "\n";
          }
          MessageBox.Show(Tempstr);
        }
    }
}