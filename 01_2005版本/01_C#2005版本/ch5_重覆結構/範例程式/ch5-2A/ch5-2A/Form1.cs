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
        {   //宣告
            int i;
            string Temp="";
            //處理
            for (i = 1; i <= 10; i++)
                Temp = Temp + i + "\n";
            //輸出
            label1.Text = Temp;
        }
        
    }
}