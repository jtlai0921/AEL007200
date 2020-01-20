using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch3_4_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //宣告
          int A, B;
          int Total;
          //輸入及轉換
          A = int.Parse(textBox1.Text);         //將textBox1文字方塊的內容轉成數字指定給A變數
          B = int.Parse(textBox2.Text);         //將textBox2文字方塊的內容轉成數字指定給B變數
          //處理
          Total = A + B;                        //將A與B的值相加後，再指定給Total變數
          //輸出
          textBox3.Text = Total.ToString() ;    //最後將Total變數的內容，再指定給textBox3文字方塊
        }
    }
}