using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  //�D�{��
            int a=10;int b=20;
            MyAdd(a,b);    //�I�s�Ƶ{��
        }
         static void MyAdd(int x,int y)       //�Q�I�s���Ƶ{��
        { //�Ƶ{��
            int sum=0;
            sum = x + y;
            MessageBox.Show("x+y=" + sum);
        }
    }
}