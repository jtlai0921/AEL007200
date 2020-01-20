using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch7_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//宣告及設定初值
         int Sum, Max = 10;
         //處理
         Sum = MyFunction(Max);                //呼叫自定函數
         label1.Text ="1+2+...+10=" + Sum;     //輸出
        }
        static int MyFunction(int X)
        {//宣告
         int i, total=0;
         //處理
         for(i = 1;i<=X;i++)
            total = total + i;
         return total;  //控制權回到呼叫函數的地方
        }

    }
}