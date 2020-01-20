using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch8_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int i, j;
           string Temp="";
           for(i = -4;i<=4;i++)
           {
             for(j = 1;j<=Math.Abs(i) + 1;j++)
             Temp = Temp + "$";
             Temp = Temp + "\n";
           }
           label1.Text = Temp;
        }
    }
}