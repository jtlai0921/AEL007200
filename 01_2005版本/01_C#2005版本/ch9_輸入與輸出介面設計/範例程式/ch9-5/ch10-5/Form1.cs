using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch10_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
         //開啟Form2表單
         Form2 CallForm2 = new Form2();
         //顯示學生的註冊資料
         CallForm2.richTextBox1.Text += "姓名：" + this.textBox1.Text + "\n" ;
         CallForm2.richTextBox1.Text += "身分證字號：" + this.maskedTextBox1.Text + "\n";
         CallForm2.richTextBox1.Text += "聯絡電話：" + this.maskedTextBox2.Text + "\n";
         CallForm2.richTextBox1.Text += "電子信箱：" + this.maskedTextBox3.Text + "\n";
         CallForm2.Show();
        }
    }
}