using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch5_3D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//�Ĥ@�ظѪk�G�W�U���|�k
            int i, j;
            string Temp = "";
            //�B�z
            for (i = 5; i >= 1; i--)      //�~�j��
            {
                for (j = 1; j <= i; j++)  //���j��
                {
                    Temp = Temp + "$";
                }
                Temp = Temp + "\n";   //����
            }
            for (i = 2; i <= 5; i++)      //�~�j��
            {
                for (j = 1; j <= i; j++)  //���j��
                {
                    Temp = Temp + "$";
                }
                Temp = Temp + "\n";   //����
            }//��X
            label1.Text = Temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {//�ĤG�ظѪk�G�Q�ε����
            int i, j;
            string Temp = "";
            for (i = -4; i <= 4; i++)    //�~�j��
            {
                for (j = 1; j <= Math.Abs(i) + 1; j++)  //���j��
                {
                    Temp = Temp + "$";
                }
                Temp = Temp + "\n";   //����
            }//��X
            label1.Text = Temp;
        }
    }
}