using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// ==== ���;�ƶü�====
            string TempStr;
            int[] A = new int[11];
            int i;
            TempStr = "��l��ơ@�G";
            Random r = new Random();
            for (i = 1; i <= 10; i++)
            {
                A[i] = r.Next(1, 101);  //����1~100����ƶüƭ�
                TempStr = TempStr + "   " + string.Format("{0:D2}", A[i]);
            }
            label1.Text = TempStr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          int[] A = new int[7];
          int i, j, x;
          string Temp="";
          Random r = new Random();
            for (i = 1; i <= 100; i++)
            {
                x = r.Next(1, 7);  //����1~6����ƶüƭ�
                A[x]=A[x]+1;
            }
           for(j = 1;j<=6;j++)
              Temp = Temp + j + "�I" + "    " + A[j] + "��" + "\n";
           MessageBox.Show(Temp);
        }

    }
}