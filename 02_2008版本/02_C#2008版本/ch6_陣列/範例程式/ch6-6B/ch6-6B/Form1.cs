using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;   //�ޥ�System.Collections
namespace ch6_6B
{
    public partial class Form1 : Form
    {
        ArrayList Score = new ArrayList();
        int i, sp = 0;
        int[] A = new int[] { 60, 65, 70, 80, 90 };

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // ��J��P�Ǧ��Z��}�C��C��
            for (i = 0; i <= 4; i++)
            {
                Score.Add(A[i]);
            }
            ProcessScore();  //�I�s�Ƶ{��
        }

        private void button2_Click(object sender, EventArgs e)
        {
          Score.Sort();     //�}�C�Ƨ�
          sp = 1;           //���W�Ƨ�
          ProcessScore();   //�I�s�Ƶ{��
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Score.Sort();     //�}�C�Ƨ�
            sp = 2;           //����Ƨ�
            ProcessScore();   //�I�s�Ƶ{��
        }
        private void ProcessScore()   //�B�z���Z���Ƶ{��
        {
        string Temp;
        Temp = "�y���@�@���Z" + "\n";
        Temp += "============" + "\n";
        label3.Text="";
        if(sp == 0 | sp == 1)     //���W�Ƨ�
        {
          for(i = 0;i<=Score.Count - 1;i++)
            Temp += (i + 1) + "     " + Score[i] + "\n";
        }
        else if(sp == 2)        //����Ƨ�
        {
          for(i = Score.Count - 1;i>=0;i--)
            Temp += (i + 1) + "     " + Score[i] + "\n";
        }
            label3.Text = Temp;
       }
    }
}