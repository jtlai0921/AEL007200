using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch6_3_2C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //�ŧi
            string D1, D2 = "", D3;
            int i;
            string[] A = new string[10];
            //��J
            D1 = textBox1.Text;
            //�B�z
            D3 = D1;
            for (i = 0; i <= D1.Length - 1; i++)
                A[i] = D1.Substring(i, 1);   //�N��@�����@�Ӧr����J�}�C��
            for (i = D1.Length - 1; i >= 0; i--)      //�q�̫�@�Ӷ}�l��ܥX��
                D2 = D2 + A[i];
            if (D2 == D3)
                MessageBox.Show(D3 + "�O�j��");    //��X
            else
                MessageBox.Show(D3 + "���O�j��");  //��X
        }
    }
}