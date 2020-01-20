using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch3_4_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //加法
        {//宣告
          int A, B, C;
          //輸入及轉換
          A = int.Parse(textBox1.Text);
          B = int.Parse(textBox2.Text);
          //處理
          C = A + B;
          //輸出
          textBox3.Text = C.ToString();
        }

        private void button2_Click(object sender, EventArgs e)  //減法
        {
            int A, B, C;
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);
            C = A - B;
            textBox3.Text = C.ToString();
        }

        private void button3_Click(object sender, EventArgs e)  //乘法
        {
            int A, B, C;
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);
            C = A * B;
            textBox3.Text = C.ToString();
        }

        private void button4_Click(object sender, EventArgs e)  //除法
        {
            int A, B, C;
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);
            C = A / B;
            textBox3.Text = C.ToString();
        }
    }
}