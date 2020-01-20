using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch7_8B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=10,b=15;
            label1.Text = "最大公因數為=" + MaxFacter(a, b);
        }
        static int MaxFacter(int a,int b)  //函數名稱
        {
            int c;
            c = a % b;
            if (c == 0)
                return b;
            else
                return MaxFacter(b, c);  //函數自己又可以呼叫自己
        }
    }
}