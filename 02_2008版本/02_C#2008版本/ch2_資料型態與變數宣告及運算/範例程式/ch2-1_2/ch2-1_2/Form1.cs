using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch2_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {//�ŧi�ܼ�
        string Stu_Name;                    //�ŧi�ǥͩm�W���r����
        int Chi_Score, Eng_Score, Average;  //�ŧi���P�^�妨�Z�����
        //��J���ഫ
        Stu_Name = TextBox1.Text;
        Chi_Score = int.Parse (TextBox2.Text);
        Eng_Score = int.Parse (TextBox3.Text);
        //�B�z
        Average = (Chi_Score + Eng_Score) / 2;
        //��X
        MessageBox.Show(Stu_Name + "�@�P�Ǫ��������Z�G" + Average);
        }
    }
}