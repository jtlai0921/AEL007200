using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch7_6A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //�ŧi�Ϊ�ȳ]�w
            int Sum, Max = 10;
            //�B�z
            Sum = MyFunction(Max);                //�I�s�۩w���
            //��X
            label1.Text = "1*2*...*10=" + Sum;
        }
        static int MyFunction(int X)
        {   //�ŧi�Ϊ�ȳ]�w
            int i, total = 1;
            //�B�z
            for (i = 1; i <= X; i++)
                total = total * i;
            return total;  //�����v�^��I�s��ƪ��a��
        }

    }
}