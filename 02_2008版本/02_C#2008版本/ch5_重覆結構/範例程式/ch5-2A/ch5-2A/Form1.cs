using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch5_2A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //�ŧi
            int i;
            string Temp="";
            //�B�z
            for (i = 1; i <= 10; i++)
                Temp = Temp + i + "\n";
            //��X
            label1.Text = Temp;
        }
        
    }
}