using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch5_3A
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
            string Temp="";
            //�B�z
            for (i = 1; i <= 9; i++)      //�~�j��
            {
                for (j = 1; j <= 9; j++)  //���j��
                {
                     Temp = Temp + i.ToString() + "*" + j.ToString() + "=" + string.Format("{0:D2}",(i * j)) + "  ";
             }
                Temp = Temp + "\n";
            }//��X
            textBox1.Text = Temp;
        }
    }
}