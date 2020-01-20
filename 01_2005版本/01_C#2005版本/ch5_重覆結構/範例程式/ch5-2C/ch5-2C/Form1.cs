using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch5_2C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            string Temp = "";
            for (i = 1; i <= 5; i++)
                Temp = Temp + "*" + "\n";
            label1.Text = Temp;
        }
    }
}