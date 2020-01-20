using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch1_1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //宣告變數及設定初值
            int C_Score, E_Score, Average;
            C_Score=60;
            E_Score=70;
            //處理及輸出
            Average = (C_Score + E_Score) / 2;
            if (Average >= 60)
                MessageBox.Show ("及格");
            else
                MessageBox.Show  ("不及格");
        }

    }
}