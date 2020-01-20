using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ch12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            int Count = 1;
            while (Count != 10)
            {
                Sum = Sum + Count;
                Count += 2;
            }
            MessageBox.Show("1到10的奇數和=" + Sum);
        }
    }
}
