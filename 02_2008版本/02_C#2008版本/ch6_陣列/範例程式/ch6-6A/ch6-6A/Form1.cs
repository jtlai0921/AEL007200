using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;   //�ޥ�System.Collections
namespace ch6_6A
{
    public partial class Form1 : Form
    {   //�ŧi�Ϊ�ȳ]�w
        ArrayList Score = new ArrayList();
        int i, Sum = 0;
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
                Score.Add(A[i]); //�NA�}�C����ƥ[�J��Score�}�C���O��
            }
            ProcessScore();  //�I�s�Ƶ{��
        }
        private void button2_Click(object sender, EventArgs e)
        {
         Score.RemoveAt(4);
         ProcessScore();     //�I�s�Ƶ{��
        }
        private void ProcessScore()   //�B�z���Z���Ƶ{��
        {
            string Temp = "�y���@�@���Z" + "\n";
            Temp += "============" + "\n";
            //�M����r�ؤ��e
             label3.Text="";
             label4.Text="";
             label5.Text="";
             Sum = 0;
            // �B�z
            for (i = 0; i <= Score.Count - 1; i++)
            {
                Temp += (i + 1) + "�@�@�@" + Score[i] + "\n";
                Sum = Sum + (int)(Score[i]);
            }
            // ��X
            label3.Text = Temp;
            label4.Text = System.Convert.ToString(Sum);
            label5.Text = System.Convert.ToString(Sum / Score.Count);
        }
    }
}