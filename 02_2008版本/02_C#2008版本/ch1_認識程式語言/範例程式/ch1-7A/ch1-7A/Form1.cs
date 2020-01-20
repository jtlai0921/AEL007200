using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch1_7A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                button1.Text = i.ToString();
                Delay();  //呼叫延遲時間的副程式
            }
        }
        private void Delay()  //延遲時間的副程式
        {
            for (int i = 1; i <= 10000; i++)
                Application.DoEvents(); //執行某一事件，以達到延遲效果
        }

    }
}