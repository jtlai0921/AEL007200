using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch2_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //�ŧi�γ]�w���
            int t;  
            int total=1;  //(��short�אּint)
            //�B�z
            for (t = 1; t <= 10; t++)
                total = total * t;
            //��X
            MessageBox.Show("10!=" + total.ToString() );
        }
    }
}