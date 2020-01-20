using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch10_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
          string Temp="";
          if(checkBox1.Checked == true)
            Temp += checkBox1.Text + "\n";
          if(checkBox2.Checked == true)
            Temp += checkBox2.Text + "\n";
          if(checkBox3.Checked == true)
            Temp += checkBox3.Text + "\n";
          if(checkBox4.Checked == true)
            Temp += checkBox4.Text + "\n";
          if(checkBox5.Checked == true)
            Temp += checkBox5.Text + "\n";
          textBox1.Text = Temp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}