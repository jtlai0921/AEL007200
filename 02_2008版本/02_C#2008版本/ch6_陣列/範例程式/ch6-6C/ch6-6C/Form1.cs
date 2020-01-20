using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;   //引用System.Collections
namespace ch6_6C
{
    public partial class Form1 : Form
    {
        ArrayList Score = new ArrayList();
        int i;
        int[] A = new int[] { 60, 65, 70, 80, 90 };

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Score.Insert(5, 99);
            ProcessScore();  //呼叫副程式
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 輸入位同學成績到陣列串列中
            for (i = 0; i <= 4; i++)
            {
                Score.Add(A[i]);
            }
            ProcessScore();  //呼叫副程式
        }
        private void ProcessScore()   //處理成績的副程式
        {
            string Temp;
            Temp = "座號　　成績" + "\n";
            Temp += "============" + "\n";
            label3.Text = "";
            for (i = 0; i <= Score.Count - 1; i++)
            Temp += (i + 1) + "     " + Score[i] + "\n";
            label3.Text = Temp;
        }

    }
}