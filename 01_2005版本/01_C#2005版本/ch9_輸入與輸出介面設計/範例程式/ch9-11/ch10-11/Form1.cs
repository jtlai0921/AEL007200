using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch10_11
{
    public partial class Form1 : Form
    {  string DataItem;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("國立台灣科大");
            comboBox1.Items.Add("國立台灣師大");
            comboBox1.Items.Add("國立高雄第一科大");
            comboBox1.Items.Add("國立高雄應用科大");
            comboBox1.Items.Add("國立屏東科大");
            comboBox1.SelectedIndex = 2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
          label2.Text = "你喜歡的課程為：" + "\n";
          DataItem = comboBox1.Text;
          if (DataItem != "")  //判斷使用者是否有選課
          //判斷輸入的資料在ComboBox清單中是否已經存在，-1代表不存在
          {
              if (comboBox1.Items.IndexOf(DataItem) == -1)
              {
                  comboBox1.Items.Add(DataItem); //使用者選課資料加入到ComboBox中
                  label2.Text += DataItem;
              }
              else
                  label2.Text += comboBox1.Text;
          }
          else
          label2.Text = "你尚未輸入或選取資料！";
        }
    }
}