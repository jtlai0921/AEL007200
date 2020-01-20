using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch4_1B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//第二種方法
             //宣告
            int Score=50;
             //處理
            if (Score <= 60)
            {//輸出
                MessageBox.Show("您必須補考！");
                MessageBox.Show("請再多加油哦！");
                MessageBox.Show("希望補考能夠順利通過！");
            }
        }
    }
}