using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ch9_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("訊息內容");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("使用MessageBoxButtons.OK", "回覆按鈕設定值", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("使用MessageBoxButtons.OKCancel", "回覆按鈕設定值", MessageBoxButtons.OKCancel);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("使用MessageBoxButtons.AbortRetrylgnore", "回覆按鈕設定值", MessageBoxButtons.AbortRetryIgnore);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("使用MessageBoxButtons.YesNoCancel", "回覆按鈕設定值", MessageBoxButtons.YesNoCancel);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("使用MessageBoxButtons.YesNo", "回覆按鈕設定值", MessageBoxButtons.YesNo);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("使用MessageBoxButtons.RetryCancel", "回覆按鈕設定值", MessageBoxButtons.RetryCancel);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Asterisk圖示", "圖示設定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information圖示", "圖示設定", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error圖示", "圖示設定", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hand圖示", "圖示設定", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stop圖示", "圖示設定", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exclamation圖示", "圖示設定", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning圖示", "圖示設定", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Question圖示", "圖示設定", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("這是機密資料你確定要刪除嗎?", "傳回值測試", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("機密資料刪除成功了!!!", "刪除成功!");
            }
            else
                MessageBox.Show("不刪除了!!!", "刪除失敗!");
        }
    }
}
