using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch6_9_3
{
    public partial class Form1 : Form
    {
        int i;
        int[] Score ={ 77, 88, 66, 100, 55, 99 };  //��ȳ]�w
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "��l��ơG";
            for (i = 0; i <= Score.Length - 1; i++)
                label1.Text += Score[i] + "    ";
            label1.Text += "\n";
            label1.Text += "=====================================";
        }

        private void button2_Click(object sender, EventArgs e)
        {
        i = Array.IndexOf(Score, 100);
        label2.Text = "���Z��ơu" + Score[i] +"�v�b�}�C�������X�{�����ޭȬ�" + (i + 1) + "  ��m";
        }
    }
}