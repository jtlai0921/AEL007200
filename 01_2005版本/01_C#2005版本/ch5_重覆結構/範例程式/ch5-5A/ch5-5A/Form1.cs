using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch5_5A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //for�j��
            int i, sum = 0;
            //�B�z
            for (i = 1; i <= 10; i++)
                sum = sum + i;
            //��X
            MessageBox.Show("1+2+3+...+10=" + sum);
        }

        private void button2_Click(object sender, EventArgs e)
        {   //while�j��
            int i=1, sum = 0;
            //�B�z
            while (i <= 10)
            {
                sum = sum + i;
                i += 1;
            }//��X
            MessageBox.Show("1+2+3+...+10=" + sum);
        }
    }
}