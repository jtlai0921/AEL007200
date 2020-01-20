using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch5_5C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//10進位轉換成進位
            int D;
            string S = "";
            //輸入及轉換
            D = int.Parse(textBox1.Text);
            //處理
            while (D >= 1)
            {
                S = (D % 2) + S;   //子串連結
                D = (int)(D / 2);  //取商取
            }//輸出

            MessageBox.Show(textBox1.Text + "的進位為：" + S);
        }

    }
}