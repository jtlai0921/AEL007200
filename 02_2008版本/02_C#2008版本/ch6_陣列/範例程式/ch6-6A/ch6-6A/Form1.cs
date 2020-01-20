using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;   //引用System.Collections
namespace ch6_6A
{
    public partial class Form1 : Form
    {   //宣告及初值設定
        ArrayList Score = new ArrayList();
        int i, Sum = 0;
        int[] A = new int[] { 60, 65, 70, 80, 90 };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 輸入位同學成績到陣列串列中
            for (i = 0; i <= 4; i++)
            {
                Score.Add(A[i]); //將A陣列的資料加入到Score陣列類別中
            }
            ProcessScore();  //呼叫副程式
        }
        private void button2_Click(object sender, EventArgs e)
        {
         Score.RemoveAt(4);
         ProcessScore();     //呼叫副程式
        }
        private void ProcessScore()   //處理成績的副程式
        {
            string Temp = "座號　　成績" + "\n";
            Temp += "============" + "\n";
            //清除文字框內容
             label3.Text="";
             label4.Text="";
             label5.Text="";
             Sum = 0;
            // 處理
            for (i = 0; i <= Score.Count - 1; i++)
            {
                Temp += (i + 1) + "　　　" + Score[i] + "\n";
                Sum = Sum + (int)(Score[i]);
            }
            // 輸出
            label3.Text = Temp;
            label4.Text = System.Convert.ToString(Sum);
            label5.Text = System.Convert.ToString(Sum / Score.Count);
        }
    }
}