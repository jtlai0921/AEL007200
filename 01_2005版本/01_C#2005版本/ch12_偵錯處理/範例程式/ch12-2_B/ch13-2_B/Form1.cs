using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch13_2_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short t;
            short total=1;
            for (t = 1; t <= 10; t++)
            {
                total = total*t;
            }
            MessageBox.Show("10!=" + total);
        }
    }
}