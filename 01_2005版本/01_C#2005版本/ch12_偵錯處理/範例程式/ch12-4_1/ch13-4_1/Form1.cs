using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch13_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c=0;
            string d;
            a = 60;
            b = 70;
            c=Average(a, b);   //呼叫計算平均成績的副程式
            if (c >= 60)
                d = "及格！";
            else
                d = "不及格！";
            MessageBox.Show(d);
        }
        static int Average(int a, int b)    //被呼叫的副程式
        { //副程式
            int aver=0;
            aver = (a + b) / 2;
            return aver;  //控制權回到呼叫函數的地方
        } 
    }
}