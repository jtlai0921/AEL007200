using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch10_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          string Username;
          string Password;
          Username = textBox1.Text;
          Password = textBox2.Text;
          if(Username == "Sean" && Password == "123456")
            MessageBox.Show("您是合法使用者！");

        }
    }
}