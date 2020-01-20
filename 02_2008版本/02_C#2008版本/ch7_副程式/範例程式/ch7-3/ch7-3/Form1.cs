using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  //主程式
            int a = 10;
            int b = 20;
            string Temp1 = "呼叫前：" + "a=" + a + "　　　" + "b=" + b;
            label1.Text = Temp1;
            CallByValue(a, b);    //呼叫副程式(傳值呼叫)
            string Temp2 = "呼叫後：" + "a=" + a + "　　　" + "b=" + b;
            label2.Text = Temp2;
        }
        static void CallByValue(int x, int y)    //被呼叫的副程式
        { //副程式
            x = 100;
            y = 200;
        }

    }
}