using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch4_2D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //�ŧi
            int A;
            //��J���ഫ
            A = int.Parse(textBox1.Text);
            //�B�z�ο�X
            if (A >= 0)
                MessageBox.Show("A=" + A);
            else
                A = (-1) * A;
            MessageBox.Show("A=" + A);
        }
    }
}