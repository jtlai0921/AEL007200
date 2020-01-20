using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch4_1A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  //第一種方法
         int Score;
         Score =int.Parse(textBox1.Text);
         if (Score >= 60)  MessageBox.Show ("通過了");
        }

        private void button2_Click(object sender, EventArgs e)
        {  //第二種方法
            int Score;
            Score = int.Parse(textBox1.Text);
            if (Score >= 60)
            {
                MessageBox.Show("通過了");
            }
        }
    }
}