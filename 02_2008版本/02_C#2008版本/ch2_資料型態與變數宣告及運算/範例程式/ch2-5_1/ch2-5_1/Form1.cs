using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch2_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {//�[�k�B��
            //�ŧi
           long Total;
           int A, B;
           //��J���ഫ
           A = int.Parse (TextBox1.Text);
           B = int.Parse (TextBox2.Text);
           //�B�z
           Total = A + B;
           //��X
           Label4.Text = A + "+" + B + "=" + Total;
        }

        private void Button2_Click(object sender, EventArgs e)
        {//��k�B��   
            //�ŧi
            long Total;
            int A, B;
            //��J���ഫ
            A = int.Parse(TextBox1.Text);
            B = int.Parse(TextBox2.Text);
            //�B�z
            Total = A - B;
            //��X
            Label5.Text = A + "-" + B + "=" + Total;
        }
    }
}