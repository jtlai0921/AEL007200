using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch8_1_3A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         string Username,Password;
         Username = textBox1.Text;
         Password = textBox2.Text;
         if ((Username.CompareTo("abc")==0) && (Password.CompareTo("123")==0)) 
            MessageBox.Show("登入成功！");
         else
            MessageBox.Show("登入失敗！");
        }
    }
}