using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch13_1_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mytest2Sub();  //呼叫副程式
        }
        static void Mytest1Sub()
        {
            MessageBox.Show("副程式測試！");
        }
    }
}