using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;   //�ޥ�System.Collections
namespace ch6_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      private void button1_Click(object sender, EventArgs e)
      {//�ŧi�Ϊ�ȳ]�w
        ArrayList Score=new ArrayList();
        int i, Sum=0;
        int[] A =new int[] {60,65,70,80,90};
        string Temp= "�y���@�@���Z" + "\n";
        Temp += "============" + "\n";
        // ��J5��P�Ǧ��Z��}�C��C��
        for(i = 0;i<=4;i++)
        {
            Score.Add(A[i]);  //�NA�}�C����ƥ[�J��Score�}�C���O��
        }
        // �B�z
        for (i = 0; i <= Score.Count - 1; i++)
        {
            Temp += (i + 1) + "�@�@�@" + Score[i] + "\n";
            Sum = Sum + (int)(Score[i]);
        }
        // ��X
        label3.Text  = Temp;
        label4.Text = System.Convert.ToString(Sum);
        label5.Text = System.Convert.ToString(Sum / Score.Count);
        }
    }
}