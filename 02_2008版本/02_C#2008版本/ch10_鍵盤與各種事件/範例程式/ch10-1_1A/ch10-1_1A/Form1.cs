using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ch10_1_1A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((byte)e.KeyChar == 13)  //如果按下Enter鈕時
                textBox2.Focus();
            if ((e.KeyChar < '0' || e.KeyChar > '9'))
                // e.Handled = true;       //表示表單不接收
                MessageBox.Show("你的國文成績輸入錯誤!!!");
        }
    }
}
