using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch6_3_2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //�ŧi
            int[] A = new int[6];
            int i;
            //��ȳ]�w
            int sum = 0;
            A[0] = 60; A[1] = 70; A[2] = 80; A[3] = 85; A[4] = 90; A[5] = 100;
            //�B�z
            for (i = 0; i <= 5; i++)
                sum += A[i];
            //��X
            MessageBox.Show("�������Z���G" + sum/6);
            MessageBox.Show("�`�����G" + sum);
        }
    }
}