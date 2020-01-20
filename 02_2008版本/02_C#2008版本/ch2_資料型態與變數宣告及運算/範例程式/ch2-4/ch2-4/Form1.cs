using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*題目：計算圓的面積與周長
            圓面積公式：PI*R2
            圓周長公式：*PI*R
            */
            //宣告
            double R, A, L;    //宣告三個變數R,A,L為倍精準度
            const double PI = 3.141592;      //宣告「圓周率」為.14的常數
            //處理
            R = 3;                           //初值設定
            A = PI * (Math.Pow(R, 2));       //計算圓面積
            L = 2 * PI * R;                  //計算圓周長
            //輸出
            MessageBox.Show("圓面積=" + A.ToString());
            MessageBox.Show("圓周長=" + L.ToString());
        }
    }
}