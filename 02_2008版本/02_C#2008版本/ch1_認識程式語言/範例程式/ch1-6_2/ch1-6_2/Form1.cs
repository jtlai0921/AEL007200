using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch1_6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;     //啟動時鐘
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;    //指每秒變動一次
            timer1.Enabled = false;    //關閉時鐘
        }

        private void timer1_Tick(object sender, EventArgs e)
        {//顯示目前的時間
            label1.Text = "現在時間" + DateTime.Now.ToString();
        }
    }
}