using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch5_3C
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
            for (i = 5; i >= 1; i--)       //�~�j��
            {
                for (j = 1; j <= i; j++)   //���j��
                {
                    Temp = Temp + "$";
                }
                Temp = Temp + "\n";   //����
            }//��X
            label1.Text = Temp;
        }
    }
}