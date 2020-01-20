using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch8_1_13D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          string Str= "Computer And Information";
          int i, t=0;
          for(i = 0;i<=Str.Length-1;i++)
            if(Str.Substring(i,1) == "m")
              t+=1;
      MessageBox.Show("在Computer And Information 字串中共有：" + t + "個m字元");
         }
    }
}