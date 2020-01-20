using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ch11_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化設定為隱藏groupBox1與groupBox2
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {//系統介紹
            string Temp;
            Temp = "歡迎使用本系統！" + "\n";
            Temp += "開發工具為VC#2008物件導向語言。";
            MessageBox.Show(Temp);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {//設定標題文字
            this.Text = "本單元是介紹ToolStrip工具列";
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
        }

        private void 中翻英ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void 英翻中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {//英翻中
            string S;
            S = textBox1.Text;
            switch (S)
            {
                case "book":
                    label3.Text = "書本";
                    break;
                case "computer":
                    label3.Text = "電腦";
                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {//中翻英
            string S;
            S = textBox2.Text;
            switch (S)
            {
                case "書本":
                    label4.Text = "book";
                    break;
                case "電腦":
                    label4.Text = "computer";
                    break;
            }
        }

        private void 藍色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Blue;
        }

        private void 紅色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Red;
        }

        private void 綠色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Green;
        }

        private void 黑色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           //設定字體大小
            int FontSize;
            FontSize = (toolStripComboBox1.SelectedIndex + 1) * 5;
            label7.Font = new Font("新細明", FontSize, FontStyle.Bold);
        }
    }
}
