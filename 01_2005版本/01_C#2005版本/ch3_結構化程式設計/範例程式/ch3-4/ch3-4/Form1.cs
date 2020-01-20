using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {//宣告及指定初值
        int A, B, C, D;
        A = 20;                  //將20指定給A
        B = 40;                  //將40指定給B
        //處理
        C = A + B;               //將A與B的值相加後，再指定給C
        D = A / B;               //將A與B的值相除後，再指定給D
        //輸出
        MessageBox.Show("C=" + C);
        MessageBox.Show("D=" + D);
        }
    }
}