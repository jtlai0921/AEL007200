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
        {  //�ŧi
           int c, f;
           //��J    
           c = int.Parse(textBox1.Text);
           //�B�z
           f = c * 9 / 5 + 32;
           //��X
           textBox2.Text = f.ToString() ; 
        }
    }
}