using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch7_8A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = 6,Sum;
            Sum = Total(N);                //呼叫自定函數
            label1.Text = "Sum=" + Sum;
        }
        static int Total(int N)  //函數名稱
        {
            if (N <= 2)
                return 1;
            else
                return Total(N-2) + Total(N - 1); //函數自己又可以呼叫自己
        }
    }
}