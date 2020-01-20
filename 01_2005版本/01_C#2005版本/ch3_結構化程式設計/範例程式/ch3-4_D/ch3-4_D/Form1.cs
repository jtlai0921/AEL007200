using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch3_4_D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  //宣告
           int c, f;
           //輸入    
           c = int.Parse(textBox1.Text);
           //處理
           f = c * 9 / 5 + 32;
           //輸出
           textBox2.Text = f.ToString() ; 
        }
    }
}