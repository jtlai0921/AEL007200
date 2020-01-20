using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ch11_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ShowForm = new Form2();    //建立Form2實體
            ShowForm.textBox1.Text = this.textBox1.Text;
            ShowForm.Show();                 //顯示Form2表單
        }
    }
}
