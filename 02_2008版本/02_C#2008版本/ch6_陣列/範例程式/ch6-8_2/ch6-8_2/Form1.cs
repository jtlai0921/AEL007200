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
        Low = 0;                                   //�]�w�Ĥ@�Ӧr��
        High = 9;                                  //�]�w�̫�@�Ӧr��
        Searchtime = 0;                            //�j�M���ƪ�ȳ]�w��0
        Middle = (int)((Low + High)/2);            //�j�M������
        do
        {
            Searchtime = Searchtime + 1;
            if (Temp[Middle] == word)              //�����
              {
                textBox2.Text = System.Convert.ToString(Middle)  ;    //��ܸ�Ʀ�m
                textBox3.Text = System.Convert.ToString(Searchtime);  //��ܷj�M����
                break;                            //���X�j��
               }
            else if(Temp[Middle] < word) 
                Low = Middle + 1;                 //���ܥ��b��
            else 
                High = Middle - 1;                //���ܥk�b��
            Middle = (int)((Low + High) / 2);     //���ܤ�����
        }
        while(Low <= High);
        }
    }
}