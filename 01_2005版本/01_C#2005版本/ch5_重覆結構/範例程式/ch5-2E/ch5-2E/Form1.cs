using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch5_2E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //宣告及初值設定
          int D1, D2=0, D3, i;
          int [] A=new int[10];
          //輸入及轉換
          D1 = int.Parse(textBox1.Text);
          //處理
          D3 = D1;
          for(i=1;i<=10;i++)
          {
            A[i] = D1 % 10;
            D1 = (int)(D1 / 10);
            D2 = D2 * 10 + A[i];
            if (D1 == 0) 
              break;
          }
          if (D2 == D3)
              MessageBox.Show(D3 + "是迴文");    //輸出
          else
              MessageBox.Show(D3 + "不是迴文");    //輸出
        }
    }
}