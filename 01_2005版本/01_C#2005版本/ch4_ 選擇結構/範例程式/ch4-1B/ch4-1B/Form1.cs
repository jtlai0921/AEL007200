using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch4_1B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//�ĤG�ؤ�k
             //�ŧi
            int Score=50;
             //�B�z
            if (Score <= 60)
            {//��X
                MessageBox.Show("�z�����ɦҡI");
                MessageBox.Show("�ЦA�h�[�o�@�I");
                MessageBox.Show("�Ʊ�ɦү�����Q�q�L�I");
            }
        }
    }
}