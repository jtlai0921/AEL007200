using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch5_3E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //�ŧi
            int i, j;
            string Temp = "";
            //�B�z
            for (i = 1; i <= 6; i++)      //�~�j��
            {
                for (j = 1; j <= i; j++)  //���j��
                {
                    Temp = Temp + j;
                }
                Temp = Temp + "\n";   //����
            }//��X
            label1.Text = Temp;
        }
    }
}