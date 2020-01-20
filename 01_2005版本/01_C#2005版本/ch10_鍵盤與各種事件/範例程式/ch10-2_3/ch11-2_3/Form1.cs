using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch11_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Text = "您按下了";
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Text = "你放開了";
        }
    }
}