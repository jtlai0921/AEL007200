using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {//�ŧi�Ϋ��w���
        int A, B, C, D;
        A = 20;                  //�N20���w��A
        B = 40;                  //�N40���w��B
        //�B�z
        C = A + B;               //�NA�PB���Ȭۥ[��A�A���w��C
        D = A / B;               //�NA�PB���Ȭ۰���A�A���w��D
        //��X
        MessageBox.Show("C=" + C);
        MessageBox.Show("D=" + D);
        }
    }
}