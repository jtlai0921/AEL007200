using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  //�D�{��
            int a = 10;
            int b = 20;
            string Temp1 = "�I�s�e�G" + "a=" + a + "�@�@�@" + "b=" + b;
            label1.Text = Temp1;
            CallByValue(a, b);    //�I�s�Ƶ{��(�ǭȩI�s)
            string Temp2 = "�I�s��G" + "a=" + a + "�@�@�@" + "b=" + b;
            label2.Text = Temp2;
        }
        static void CallByValue(int x, int y)    //�Q�I�s���Ƶ{��
        { //�Ƶ{��
            x = 100;
            y = 200;
        }

    }
}