using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch5_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //�ŧi�Ϊ�ȳ]�w
            int x = 1, Sum = 0;
            //�B�z
            while (x <= 10)
            {
                Sum = Sum + x;
                x = x + 1;
            }//��X
            label1.Text = "1+2+3+...+10=" + Sum;
        }
    }
}