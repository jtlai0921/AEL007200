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
          keyword = 100;  //���]���d��100
          c = 0;
          TempStr2 = TempStr2 + "\n";
          TempStr2 = TempStr2 + "===========�`�Ƿj�M���G==========" + "\n";
          for(i=1;i<=10;i++)
          {
            if (keyword == A[i])  //�P�_���j�M����ƬO�_���b�}�C��
            {
                TempStr2 = TempStr2 + "�@�j�M�F" + i + "���A" + keyword + "�b�üƼƦC������" + i + " ��";
                c = 1;
                break;
            }
          }
            label2.Text = TempStr2;
            if (c == 0)
                MessageBox.Show("�䤣��" + keyword);
        }
    }
}