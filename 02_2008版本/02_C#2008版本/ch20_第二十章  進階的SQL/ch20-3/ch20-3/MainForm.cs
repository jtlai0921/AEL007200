using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch20_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 設定科系代碼ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 childform = new Form1();   //建立Form1實體
            childform.MdiParent = this;      //指定Form1的父表單為MainForm表單
            childform.Show();                //顯示MDI的子表單
        }

        private void 課程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 childform = new Form2();   //建立Form2實體
            childform.MdiParent = this;      //指定Form2的父表單為MainForm表單
            childform.Show();                //顯示MDI的子表單
        }

        private void 學生管理與選課作業ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 childform = new Form3();   //建立Form3實體
            childform.MdiParent = this;      //指定Form3的父表單為MainForm表單
            childform.Show();                //顯示MDI的子表單
        }

        private void 查詢選課記錄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 childform = new Form5();   //建立Form5實體
            childform.MdiParent = this;      //指定Form5的父表單為MainForm表單
            childform.Show();                //顯示MDI的子表單
        }
    }
}