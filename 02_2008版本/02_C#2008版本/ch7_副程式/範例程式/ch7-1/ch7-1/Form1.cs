using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //主程式
            MytestSub();    //呼叫副程式
        }
        void MytestSub()         //被呼叫的副程式
        { //副程式
            MessageBox.Show("副程式測試ok!");
        }
    }
}