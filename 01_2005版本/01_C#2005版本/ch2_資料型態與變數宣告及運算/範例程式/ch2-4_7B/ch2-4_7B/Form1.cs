using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch2_4_7B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string A = "3";
            string B = "5";
            string C;
            C = A + B;
            MessageBox.Show(C.ToString());  //µ²ªG¡G35
        }
    }
}