using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch2_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {//加法運算
            //宣告
           long Total;
           int A, B;
           //輸入及轉換
           A = int.Parse (TextBox1.Text);
           B = int.Parse (TextBox2.Text);
           //處理
           Total = A + B;
           //輸出
           Label4.Text = A + "+" + B + "=" + Total;
        }

        private void Button2_Click(object sender, EventArgs e)
        {//減法運算   
            //宣告
            long Total;
            int A, B;
            //輸入及轉換
            A = int.Parse(TextBox1.Text);
            B = int.Parse(TextBox2.Text);
            //處理
            Total = A - B;
            //輸出
            Label5.Text = A + "-" + B + "=" + Total;
        }
    }
}