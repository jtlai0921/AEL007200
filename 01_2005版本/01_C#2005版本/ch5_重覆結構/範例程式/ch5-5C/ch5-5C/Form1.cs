using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch5_5C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //�ŧi�Ϊ�ȳ]�w
            int i = 1, sum = 0;
            //�B�z
            while (sum < 1000)
            {
                sum = sum + i;
                i += 1;
            }//��X
            label1.Text = "��" + i + "�Ѫ����B���G" + sum;
        }
    }
}