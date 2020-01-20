using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ch9_8
{
    public partial class Form1 : Form
    {
        string Temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temp = textBox1.Text + "同學您好：" + "\n";
            Temp += "你喜歡的科目為：";
            if (radioButton1.Checked == true)          //點選國文
                Temp += radioButton1.Text;
            else if (radioButton2.Checked == true)    //點選英文
                Temp += radioButton2.Text;
            else if (radioButton3.Checked == true)    //點選數學
                Temp += radioButton3.Text;
            label2.Text = Temp;   
        }
    }
}
