using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch3_4_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //�[�k
        {//�ŧi
          int A, B, C;
          //��J���ഫ
          A = int.Parse(textBox1.Text);
          B = int.Parse(textBox2.Text);
          //�B�z
          C = A + B;
          //��X
          textBox3.Text = C.ToString();
        }

        private void button2_Click(object sender, EventArgs e)  //��k
        {
            int A, B, C;
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);
            C = A - B;
            textBox3.Text = C.ToString();
        }

        private void button3_Click(object sender, EventArgs e)  //���k
        {
            int A, B, C;
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);
            C = A * B;
            textBox3.Text = C.ToString();
        }

        private void button4_Click(object sender, EventArgs e)  //���k
        {
            int A, B, C;
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);
            C = A / B;
            textBox3.Text = C.ToString();
        }
    }
}