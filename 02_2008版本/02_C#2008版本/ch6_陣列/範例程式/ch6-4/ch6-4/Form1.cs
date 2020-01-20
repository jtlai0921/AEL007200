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
        int[] Stu_Sum = new int[4];         //�ǥ��`���Z
        int[] Stu_Average = new int[4];     //�ǥͥ������Z
        int[] Subject_Sum = new int[5];     //����`���Z
        int[] Subjcet_Average = new int[5]; //��إ������Z
        string[] Stu_Name = { "�i�T", "���|", "����", "����" };
        int[,] Score = new int[,] { { 65, 85, 78, 75, 69 }, { 66, 55, 52, 92, 47 }, { 75, 99, 63, 73, 86 }, { 77, 88, 99, 91, 100 } };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             // ======= Ū����ƨíp��U���`��======
            for (i = 0; i <= 3; i++)        //����C��
            {
                for (j = 0; j <= 4; j++)    //������
                {
                    Stu_Sum[i] = Stu_Sum[i] + Score[i, j];           //�p��X�C�@��u�P�ǡv���`���Z
                    Subject_Sum[j] = Subject_Sum[j] + Score[i, j];   //�p��X�C�@�u��ءv���`���Z
                }
            }
            //========= �L�X�}�Y========
            Temp = "�m�W�@�@���@ �^�� �@�ƾ� �@�p�� �@�{�]" + "\n";
            Temp = Temp + "===========================================" + "\n";
            // ======== �L�X���Z��=======
            for (i = 0; i <= 3; i++)       //����C��
            {
                Temp = Temp + Stu_Name[i];
                for (j = 0; j <= 4; j++)   //������
                {
                    Temp = Temp + "  �@�@" + Score[i, j];
                }
                Temp = Temp + "\n";
            }
            label1.Text = Temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {//���D�@
            int Total, Aver;
            Total = Score[3, 0] + Score[3, 1] + Score[3, 2] + Score[3, 3] + Score[3, 4];   //��X�`�X
            Aver = Total / 5;                       //��X����
            label4.Text = "�`��=" + Total + "\n" + "����=" + Aver;
        }

        private void button3_Click(object sender, EventArgs e)
        {//���D�G
            // ======== �L�X�Ǭ쥭�����Z=======
            label2.Text = "�Ǭ쥭��";
            for (j = 0; j <= 4; j++)
            {
                Subjcet_Average[j] = Subject_Sum[j] / 4;       //�p��X�C�@��ت���������
                label2.Text = label2.Text + "          " + Subjcet_Average[j];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {//���D�T
            // ======== �L�X�ǥͥ������Z=======
            label3.Text = "�ǥͦ��Z" + "\n" + "\n";
            for (i = 0; i <= 3; i++)
            {
                Stu_Average[i] = Stu_Sum[i] / 5;       //�p��X�C�@��P�Ǫ��������Z
                label3.Text = label3.Text + Stu_Average[i] + "\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {//���D�|
            label5.Text = "�{�]�C�󥭧��G" + "\n";
            for (i = 0; i <= 3; i++)        //����C��
            {
                if (Score[i, 4] < Subjcet_Average[4])
                    label5.Text = label5.Text + Stu_Name[i] + "\n";
            }
        }
 

    }
}