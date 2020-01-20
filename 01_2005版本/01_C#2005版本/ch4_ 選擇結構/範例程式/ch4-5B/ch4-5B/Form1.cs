using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch4_5B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //宣告
            int Score;
            //輸入及轉換
            Score = int.Parse(textBox1.Text);
            //處理及輸出
            switch ((int)(Score / 10))
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    textBox2.Text = "不及格";
                    break;   //離開
                case 6:
                case 7:
                case 8:
                    textBox2.Text = "及格";
                    break;
                default:
                    textBox2.Text = "優等生";
                    break;
            }

        }
    }
}