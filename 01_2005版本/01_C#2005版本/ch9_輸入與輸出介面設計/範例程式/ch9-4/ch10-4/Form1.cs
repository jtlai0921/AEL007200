using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch10_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //載入Text文件檔
            richTextBox1.LoadFile("RichTextBox.rtf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = ! richTextBox1.SelectionBullet;
        }
    }
}