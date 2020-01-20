using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch5_3A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //宣告
            int i, j;
            string Temp="";
            //處理
            for (i = 1; i <= 9; i++)      //外迴圈
            {
                for (j = 1; j <= 9; j++)  //內迴圈
                {
                     Temp = Temp + i.ToString() + "*" + j.ToString() + "=" + string.Format("{0:D2}",(i * j)) + "  ";
             }
                Temp = Temp + "\n";
            }//輸出
            textBox1.Text = Temp;
        }
    }
}