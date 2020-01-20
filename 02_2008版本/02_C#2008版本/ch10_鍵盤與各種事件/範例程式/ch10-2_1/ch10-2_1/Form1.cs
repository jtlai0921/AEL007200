using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ch10_2_1
{
    public partial class Form1 : Form
    {  //宣告及初值設定
        int Press = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//處理
            Press = Press + 1;
            MessageBox.Show("你總共按了" + Press + "下");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
