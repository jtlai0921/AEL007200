using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch11_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
          switch(listBox1.Text)
          {
              case "第0項":
                MessageBox.Show("你選了第0項");
               break;
              case "第1項":
                MessageBox.Show("你選了第1項");
               break;
              case "第2項":
                MessageBox.Show("你選了第2項");
               break;
              case "第3項":
                MessageBox.Show("你選了第3項");
               break;
              case "第4項":
                MessageBox.Show("你選了第4項");
               break;
              case "第5項":
               MessageBox.Show("你選了第5項");
               break;
          }
      }
    }
}