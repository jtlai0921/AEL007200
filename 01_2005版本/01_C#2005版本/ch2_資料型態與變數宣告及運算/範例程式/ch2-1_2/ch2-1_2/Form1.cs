using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch2_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {//宣告變數
        string Stu_Name;                    //宣告學生姓名為字串資料
        int Chi_Score, Eng_Score, Average;  //宣告國文與英文成績為整數
        //輸入及轉換
        Stu_Name = TextBox1.Text;
        Chi_Score = int.Parse (TextBox2.Text);
        Eng_Score = int.Parse (TextBox3.Text);
        //處理
        Average = (Chi_Score + Eng_Score) / 2;
        //輸出
        MessageBox.Show(Stu_Name + "　同學的平均成績：" + Average);
        }
    }
}