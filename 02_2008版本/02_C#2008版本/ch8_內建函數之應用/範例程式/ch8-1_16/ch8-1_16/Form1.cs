using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch8_1_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username, Password;
            Username = textBox1.Text;
            Password = textBox2.Text;
            if ((Username.Trim()== "abc") && (Password.Trim() =="123"))
                MessageBox.Show("�n�J���\�I");
            else
                MessageBox.Show("�n�J���ѡI");
        }
    }
}