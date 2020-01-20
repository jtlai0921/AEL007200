using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ch9_7
{
    public partial class Form1 : Form
    {
        int WordSize;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //字體大小10
            WordSize = int.Parse(radioButton1.Text);
            label1.Font = new Font("標楷體", WordSize);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //字體大小15
            WordSize = int.Parse(radioButton2.Text);
            label1.Font = new Font("標楷體", WordSize);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {//字體大小20
            WordSize = int.Parse(radioButton3.Text);
            label1.Font = new Font("標楷體", WordSize);

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //字體大小25
            WordSize = int.Parse(radioButton4.Text);
            label1.Font = new Font("標楷體", WordSize);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //字體大小30
            WordSize = int.Parse(radioButton5.Text);
            label1.Font = new Font("標楷體", WordSize);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //字體大小50
            WordSize = int.Parse(radioButton6.Text);
            label1.Font = new Font("標楷體", WordSize);
        }
    }
}
