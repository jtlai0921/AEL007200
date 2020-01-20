using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ch9_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Temp = "";
            int i;
            for (i = 0; i <= checkedListBox1.Items.Count - 1; i++)
            {
                if (checkedListBox1.GetItemChecked(i) == true)
                    Temp += checkedListBox1.Items[i].ToString() + ",";
            }
            textBox1.Text = Temp;
        }
    }
}
