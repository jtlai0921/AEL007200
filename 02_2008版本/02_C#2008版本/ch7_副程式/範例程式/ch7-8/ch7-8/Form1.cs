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
        {   //宣告
            int Result, Max = 10;
            Result = MyFunction(Max);                //呼叫自定函數
            //輸出
            label1.Text = "1*2*...*10=" + Result;
        }
        static int MyFunction(int N)  //函數名稱
        {
            if (N ==0)   //遞迴函數的終值
                return 1;
            else
                return N * MyFunction(N - 1); //函數自己又可以呼叫自己
        }

    }
}