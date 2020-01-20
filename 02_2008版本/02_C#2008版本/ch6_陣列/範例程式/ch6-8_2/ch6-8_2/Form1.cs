using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch6_8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        int[] Temp={0,1,2,3,4,5,6,7,8,9};
        int word;
        int Low, High, Middle, Searchtime;
        word = int.Parse(textBox1.Text);
        Low = 0;                                   //設定第一個字母
        High = 9;                                  //設定最後一個字母
        Searchtime = 0;                            //搜尋次數初值設定為0
        Middle = (int)((Low + High)/2);            //搜尋中間值
        do
        {
            Searchtime = Searchtime + 1;
            if (Temp[Middle] == word)              //找到資料
              {
                textBox2.Text = System.Convert.ToString(Middle)  ;    //顯示資料位置
                textBox3.Text = System.Convert.ToString(Searchtime);  //顯示搜尋次數
                break;                            //跳出迴圈
               }
            else if(Temp[Middle] < word) 
                Low = Middle + 1;                 //改變左半部
            else 
                High = Middle - 1;                //改變右半部
            Middle = (int)((Low + High) / 2);     //改變中間值
        }
        while(Low <= High);
        }
    }
}