using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch12_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 第一個表單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 childform = new Form1();   //建立Form1實體
            childform.MdiParent = this;      //指定Form1的父表單為MainForm表單
            childform.Show();                //顯示MDI的子表單
        }

        private void 第二個表單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 childform = new Form2();   //建立Form2實體
            childform.MdiParent = this;      //指定Form2的父表單為MainForm表單
            childform.Show();                //顯示MDI的子表單       
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();   //結束
        }
    }
}