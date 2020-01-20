using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch6_9_2
{
    public partial class Form1 : Form
    {
        int i;
        int[] Score ={ 77, 88, 66, 100, 55, 99 };  //初值設定
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                label1.Text = "原始資料：";
                for (i = 0; i <= Score.Length - 1; i++)
                    label1.Text += Score[i] + "    ";
                label1.Text += "\n";
                label1.Text += "=====================================";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Sort(Score);  //陣列排序
            label2.Text = "遞增排序：";
            for (i = 0; i <= Score.Length - 1; i++)
                label2.Text += Score[i] + "    ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
        Array.Sort(Score);     //陣列排序
        Array.Reverse(Score);  //陣列反轉排序
        label3.Text = "遞減排序：";
        for (i = 0; i <= Score.Length - 1; i++)
            label3.Text += Score[i] + "    ";
        }
    }
}