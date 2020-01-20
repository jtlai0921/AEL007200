using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch6_4
{
    public partial class Form1 : Form
    {
        int i, j;
        string Temp = "";
        int[] Stu_Sum = new int[4];         //學生總成績
        int[] Stu_Average = new int[4];     //學生平均成績
        int[] Subject_Sum = new int[5];     //科目總成績
        int[] Subjcet_Average = new int[5]; //科目平均成績
        string[] Stu_Name = { "張三", "李四", "王五", "雄雄" };
        int[,] Score = new int[,] { { 65, 85, 78, 75, 69 }, { 66, 55, 52, 92, 47 }, { 75, 99, 63, 73, 86 }, { 77, 88, 99, 91, 100 } };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             // ======= 讀取資料並計算各科總分======
            for (i = 0; i <= 3; i++)        //控制列數
            {
                for (j = 0; j <= 4; j++)    //控制行數
                {
                    Stu_Sum[i] = Stu_Sum[i] + Score[i, j];           //計算出每一位「同學」的總成績
                    Subject_Sum[j] = Subject_Sum[j] + Score[i, j];   //計算出每一「科目」的總成績
                }
            }
            //========= 印出開頭========
            Temp = "姓名　　國文　 英文 　數學 　計概 　程設" + "\n";
            Temp = Temp + "===========================================" + "\n";
            // ======== 印出成績單=======
            for (i = 0; i <= 3; i++)       //控制列數
            {
                Temp = Temp + Stu_Name[i];
                for (j = 0; j <= 4; j++)   //控制行數
                {
                    Temp = Temp + "  　　" + Score[i, j];
                }
                Temp = Temp + "\n";
            }
            label1.Text = Temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {//問題一
            int Total, Aver;
            Total = Score[3, 0] + Score[3, 1] + Score[3, 2] + Score[3, 3] + Score[3, 4];   //算出總合
            Aver = Total / 5;                       //算出平均
            label4.Text = "總分=" + Total + "\n" + "平均=" + Aver;
        }

        private void button3_Click(object sender, EventArgs e)
        {//問題二
            // ======== 印出學科平均成績=======
            label2.Text = "學科平均";
            for (j = 0; j <= 4; j++)
            {
                Subjcet_Average[j] = Subject_Sum[j] / 4;       //計算出每一科目的平均分數
                label2.Text = label2.Text + "          " + Subjcet_Average[j];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {//問題三
            // ======== 印出學生平均成績=======
            label3.Text = "學生成績" + "\n" + "\n";
            for (i = 0; i <= 3; i++)
            {
                Stu_Average[i] = Stu_Sum[i] / 5;       //計算出每一位同學的平均成績
                label3.Text = label3.Text + Stu_Average[i] + "\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {//問題四
            label5.Text = "程設低於平均：" + "\n";
            for (i = 0; i <= 3; i++)        //控制列數
            {
                if (Score[i, 4] < Subjcet_Average[4])
                    label5.Text = label5.Text + Stu_Name[i] + "\n";
            }
        }
 

    }
}