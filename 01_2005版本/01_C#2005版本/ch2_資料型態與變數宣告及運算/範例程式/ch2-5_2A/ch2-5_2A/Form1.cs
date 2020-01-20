using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch2_5_2A
{
    public partial class Form1 : Form
    {
        string A;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         A= "大家好，我是李春雄老師";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(A.ToString());
        }
    }
}