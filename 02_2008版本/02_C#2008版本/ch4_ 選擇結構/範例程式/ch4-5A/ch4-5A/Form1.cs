using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch4_5A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  //宣告
            int Score;
            //輸入及轉換
            Score = int.Parse(textBox1.Text);
            //處理及輸出
            if (Score < 60)
                textBox2.Text = "不及格";
            else
                if (Score >= 60 & Score <= 89)
                    textBox2.Text = "及格";
                else
                    textBox2.Text = "優等生";
        }
    }
}