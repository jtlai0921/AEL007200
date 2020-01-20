using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch4_3B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //宣告
            int Score;
            string Result;
            //輸入及轉換
            Score = int.Parse(textBox1.Text);
            //處理
            Result = Score >= 60 ? "及格" : "不及格";
            //輸出
            MessageBox.Show(Result);
        }
    }
}