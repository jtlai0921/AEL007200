using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch8_1_13A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         string Str, Temp="";
         int i;
         Str = "12345";
         for(i = 0;i<=Str.Length-1;i++)
            Temp += Str.Substring(0, i+1) + "\n";
         label1.Text = Temp;
        }
    }
}