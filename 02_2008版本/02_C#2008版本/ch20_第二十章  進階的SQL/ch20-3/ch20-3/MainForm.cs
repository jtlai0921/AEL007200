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

        private void �]�w��t�N�XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 childform = new Form1();   //�إ�Form1����
            childform.MdiParent = this;      //���wForm1������欰MainForm���
            childform.Show();                //���MDI���l���
        }

        private void �ҵ{�޲zToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 childform = new Form2();   //�إ�Form2����
            childform.MdiParent = this;      //���wForm2������欰MainForm���
            childform.Show();                //���MDI���l���
        }

        private void �ǥͺ޲z�P��ҧ@�~ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 childform = new Form3();   //�إ�Form3����
            childform.MdiParent = this;      //���wForm3������欰MainForm���
            childform.Show();                //���MDI���l���
        }

        private void �d�߿�ҰO��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 childform = new Form5();   //�إ�Form5����
            childform.MdiParent = this;      //���wForm5������欰MainForm���
            childform.Show();                //���MDI���l���
        }
    }
}