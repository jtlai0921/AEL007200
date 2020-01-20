using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ch10_1_1
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
            {
                textBox2.Focus();
                textBox2.Text = "跳到第二個文字框";
            }
            else
                e.Handled = true;       //表示表單不接收
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
