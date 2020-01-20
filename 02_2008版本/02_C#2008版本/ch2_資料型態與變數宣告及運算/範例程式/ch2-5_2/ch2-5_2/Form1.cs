using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch2_5_2
{
    public partial class Form1 : Form
    {
        int A;   //表單變數(模組)
        public Form1()
        {
            InitializeComponent();
          }
        private void button1_Click(object sender, EventArgs e)
        {
            A = 50000;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(A.ToString ());
        }
    }
}