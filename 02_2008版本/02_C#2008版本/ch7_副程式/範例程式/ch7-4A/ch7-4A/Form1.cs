using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch7_4A
{
    public partial class Form1 : Form
    { //�ŧi(������ܼ�)
      int a, b;
      string Temp;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {  //�D�{��
            this.Text = "�ǭȩI�s";
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            string Temp1 = "�I�s�e�G" + "a=" + a + "�@�@�@" + "b=" + b;
            label4.Text = Temp1;
            CallByValue(a, b);    //�I�s�Ƶ{��(�ǭȩI�s)
            string Temp2 = "�I�s��G" + "a=" + a + "�@�@�@" + "b=" + b;
            label4.Text = Temp2;
        }
        static void CallByValue(int x, int y)    //�Q�I�s���Ƶ{��
        { //�Ƶ{��
            x = 100;
            y = 200;
        }

        private void button2_Click(object sender, EventArgs e)
        {  //�D�{��
            this.Text = "�ǧ}�I�s";
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            string Temp1 = "�I�s�e�G" + "a=" + a + "�@�@�@" + "b=" + b;
            label4.Text = Temp1;
            CallByAddress(ref a, ref b);    //�I�s�Ƶ{��(�ǧ}�I�s)
            string Temp2 = "�I�s��G" + "a=" + a + "�@�@�@" + "b=" + b;
            label4.Text = Temp2;
        }
        static void CallByAddress(ref int x, ref int y)    //�Q�I�s���Ƶ{��
        { //�Ƶ{��
            x = 100;
            y = 200;
        }
    }
}