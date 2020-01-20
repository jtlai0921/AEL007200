using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ch11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 childform = new Form2();   //建立Form2實體
            childform.MdiParent = this;      //指定Form2的父表單為Form1表單
            childform.Show();                //顯示MDI的子表單
        }
    }
}
