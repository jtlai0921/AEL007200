using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch3_4_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //�ŧi
          int A, B;
          int Total;
          //��J���ഫ
          A = int.Parse(textBox1.Text);         //�NtextBox1��r��������e�ন�Ʀr���w��A�ܼ�
          B = int.Parse(textBox2.Text);         //�NtextBox2��r��������e�ন�Ʀr���w��B�ܼ�
          //�B�z
          Total = A + B;                        //�NA�PB���Ȭۥ[��A�A���w��Total�ܼ�
          //��X
          textBox3.Text = Total.ToString() ;    //�̫�NTotal�ܼƪ����e�A�A���w��textBox3��r���
        }
    }
}