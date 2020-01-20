using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch7_4A
{
    public partial class Form1 : Form
    { //宣告(全域性變數)
      int a, b;
      string Temp;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {  //主程式
            this.Text = "傳值呼叫";
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            string Temp1 = "呼叫前：" + "a=" + a + "　　　" + "b=" + b;
            label4.Text = Temp1;
            CallByValue(a, b);    //呼叫副程式(傳值呼叫)
            string Temp2 = "呼叫後：" + "a=" + a + "　　　" + "b=" + b;
            label4.Text = Temp2;
        }
        static void CallByValue(int x, int y)    //被呼叫的副程式
        { //副程式
            x = 100;
            y = 200;
        }

        private void button2_Click(object sender, EventArgs e)
        {  //主程式
            this.Text = "傳址呼叫";
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            string Temp1 = "呼叫前：" + "a=" + a + "　　　" + "b=" + b;
            label4.Text = Temp1;
            CallByAddress(ref a, ref b);    //呼叫副程式(傳址呼叫)
            string Temp2 = "呼叫後：" + "a=" + a + "　　　" + "b=" + b;
            label4.Text = Temp2;
        }
        static void CallByAddress(ref int x, ref int y)    //被呼叫的副程式
        { //副程式
            x = 100;
            y = 200;
        }
    }
}