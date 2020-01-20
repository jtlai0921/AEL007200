using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch4_2C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //
            int A;
            //块の锣传
            A = int.Parse(textBox1.Text);
            //矪瞶の块
            if ((A % 2) == 0)
                MessageBox.Show("案计");
            else
                MessageBox.Show("计");
        } 
    }
}