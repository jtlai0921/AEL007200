using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ch12_6
{
    public partial class Form1 : Form
    {//宣告
        int x, y, z;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   //處理
                x = 1;
                y = 0;
                if (y == 0)
                {
                    throw new Exception("兩數相除，分母不能為0！");
                }
                z = x / y;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {   //輸出
                MessageBox.Show("結果：" + z);
            }
        }
    }
}
