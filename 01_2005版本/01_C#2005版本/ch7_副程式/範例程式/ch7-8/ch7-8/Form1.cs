using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch7_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //
            int Result, Max = 10;
            Result = MyFunction(Max);                //㊣﹚ㄧ计
            //块
            label1.Text = "1*2*...*10=" + Result;
        }
        static int MyFunction(int N)  //ㄧ计嘿
        {
            if (N ==0)   //患癹ㄧ计沧
                return 1;
            else
                return N * MyFunction(N - 1); //ㄧ计㊣
        }

    }
}