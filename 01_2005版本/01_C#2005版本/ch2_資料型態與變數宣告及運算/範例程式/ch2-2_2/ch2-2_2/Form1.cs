using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch2_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  //�ŧi�ܼ�
            int i, Sum;
           //�B�z
            for (i = 1; i <= 10; i++)
                Sum = Sun + 1;
           //��X
            MessageBox.Show("�`�ƬO�G" + Sum);
        }
    }
}