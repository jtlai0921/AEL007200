using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch4_2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//��J
            int h = 190;
         //�B�z�ο�X
            if (h > 180)
                MessageBox.Show("�z�I�n���X");
            else
                MessageBox.Show("�o�~������`");
        }
    }
}