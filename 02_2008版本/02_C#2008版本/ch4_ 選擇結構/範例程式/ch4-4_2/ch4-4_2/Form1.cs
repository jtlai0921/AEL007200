using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch4_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //宣告
            int A, B;
            int Total;
            float Average;
            //輸入及轉換
            A = int.Parse(textBox1.Text);       //將textBox1文字方塊的內容轉成數字指定給A變數
            B = int.Parse(textBox2.Text);       //將textBox2文字方塊的內容轉成數字指定給B變數
            //處理及輸出
            Total = A + B;                      //將A與B的值相加後，再指定給Total變數
            textBox3.Text = Total.ToString();   //最後將Total變數的內容，再指定給textBox3文字方塊
            Average = Total / 2;
            textBox4.Text = Average.ToString();
            switch ((int)(Average / 10))
            {
                case 10:
                case 9:
                    textBox5.Text = "甲等";
                    break;
                case 8:
                    textBox5.Text = "乙等";
                    break;
                case 7:
                    textBox5.Text = "丙等";
                    break;
                case 6:
                    textBox5.Text = "丁等";
                    break;
                default:
                    textBox5.Text = "戊等";
                    break;
            }
        }
    }
}