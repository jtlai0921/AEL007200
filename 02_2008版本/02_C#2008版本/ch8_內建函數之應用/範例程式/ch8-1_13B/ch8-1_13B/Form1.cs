using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch8_1_13B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Str1 = textBox1.Text;
            string Sex_word="";
            Sex_word = Str1.Substring(1,1);  //�_�l���ޱq0�}�l
            if (Sex_word == "1")
              textBox2.Text="�k��";
            else
              textBox2.Text="�k��";
      }
    }
}