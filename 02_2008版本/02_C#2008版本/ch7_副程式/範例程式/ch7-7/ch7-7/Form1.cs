using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch7_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// ==== ���;�ƶü�====
            //�ŧi
            string TempStr;
            int[] A = new int[11];
            int i;
            TempStr = "��l��ơ@�G";
            //�B�z
            Random r = new Random();
            for (i = 1; i <= 10; i++)
            {
                A[i] = r.Next(1, 101);  //����1~100����ƶüƭ�
                TempStr = TempStr + "   " + string.Format("{0:D2}", A[i]);
            }
            //��X
            label1.Text = TempStr;
        }
    }
}