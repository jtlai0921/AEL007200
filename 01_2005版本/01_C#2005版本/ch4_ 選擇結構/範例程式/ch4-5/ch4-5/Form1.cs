using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch4_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //宣告及初值設定
            int average, vb;
            average = 80;
            vb = 100;
            string Result;
            //處理及輸出
            if (average >= 80)
                if (vb == 100)
                    Result = "你學業成績不錯，VB程式設計更是高手!!!";
                else
                    Result = "你學業成績不錯";
            else
                Result = "你學業成績還需加油!!!";
            MessageBox.Show(Result);
        }
    }
}