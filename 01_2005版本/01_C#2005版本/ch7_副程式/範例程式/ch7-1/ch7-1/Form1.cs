using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //�D�{��
            MytestSub();    //�I�s�Ƶ{��
        }
        void MytestSub()         //�Q�I�s���Ƶ{��
        { //�Ƶ{��
            MessageBox.Show("�Ƶ{������ok!");
        }
    }
}