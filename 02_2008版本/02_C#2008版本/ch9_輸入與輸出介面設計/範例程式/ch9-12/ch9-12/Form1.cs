using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ch9_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {//加選       
            int i;
            if (ListBox1.SelectedItems.Count > 0)
            {
                for (i = 0; i <= ListBox1.SelectedItems.Count - 1; i++)
                    ListBox2.Items.Add(ListBox1.SelectedItems[i]);
                for (i = ListBox1.SelectedIndices.Count - 1; i >= 0; i--)
                    ListBox1.Items.RemoveAt(ListBox1.SelectedIndices[i]);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {//退選
            int i;
            if (ListBox2.SelectedItems.Count > 0)
            {
                for (i = 0; i <= ListBox2.SelectedItems.Count - 1; i++)
                    ListBox1.Items.Add(ListBox2.SelectedItems[i]);
                for (i = ListBox2.SelectedIndices.Count - 1; i >= 0; i--)
                    ListBox2.Items.RemoveAt(ListBox2.SelectedIndices[i]);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {//排序
            ListBox2.Sorted = true;  //ListBox2作排序
        }
    }
}
