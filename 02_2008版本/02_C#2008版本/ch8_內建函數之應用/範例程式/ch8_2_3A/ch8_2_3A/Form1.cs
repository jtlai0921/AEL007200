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
            //�Q��Try...Catch�ӰO�����~
            {
                try
                {
                    DateTime dt = DateTime.Parse(textBox1.Text);
                    string Stype = comboBox1.Text.Substring(0, 1);
                    label3.Text = dt.ToString(Stype);
                }
                catch (Exception ex)
                {
                    //�p�G�����Ϳ��~�A�N�|��ܿ��~�T��
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("�z�|����J�ƭȸ�ơI");
        }

    }
}