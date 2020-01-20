using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch8_2_3A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            //利用Try...Catch來記錄錯誤
            {
                try
                {
                    DateTime dt = DateTime.Parse(textBox1.Text);
                    string Stype = comboBox1.Text.Substring(0, 1);
                    label3.Text = dt.ToString(Stype);
                }
                catch (Exception ex)
                {
                    //如果有產生錯誤，就會顯示錯誤訊息
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("您尚未輸入數值資料！");
        }

    }
}