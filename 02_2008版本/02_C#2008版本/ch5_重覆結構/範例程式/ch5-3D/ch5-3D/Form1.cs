using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch5_3D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//第一種解法：上下重疊法
            int i, j;
            string Temp = "";
            //處理
            for (i = 5; i >= 1; i--)      //外迴圈
            {
                for (j = 1; j <= i; j++)  //內迴圈
                {
                    Temp = Temp + "$";
                }
                Temp = Temp + "\n";   //換行
            }
            for (i = 2; i <= 5; i++)      //外迴圈
            {
                for (j = 1; j <= i; j++)  //內迴圈
                {
                    Temp = Temp + "$";
                }
                Temp = Temp + "\n";   //換行
            }//輸出
            label1.Text = Temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {//第二種解法：利用絕對值
            int i, j;
            string Temp = "";
            for (i = -4; i <= 4; i++)    //外迴圈
            {
                for (j = 1; j <= Math.Abs(i) + 1; j++)  //內迴圈
                {
                    Temp = Temp + "$";
                }
                Temp = Temp + "\n";   //換行
            }//輸出
            label1.Text = Temp;
        }
    }
}