using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch6_3_2A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] A = new int[6];
            A[0]=60; A[1]=70; A[2]=80; A[3]=85; A[4]=90; A[5]=100;
            int sum;
            sum = A[0] + A[1] + A[2] + A[3] + A[4] + A[5];
            label1.Text = "總和為：" + sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] A = new int[6];
            A[0] = 60; A[1] = 70; A[2] = 80; A[3] = 85; A[4] = 90; A[5] = 100;
            int i, sum = 0;
            for (i = 0; i<=5;i++ )
                sum+=A[i];
            label1.Text = "總和為：" + sum;
        }
    }
}