using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ch19_3._A
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string ID= textBox2.Text;
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "select * from �ǥͦ��Z�� Where �Ǹ�='" + ID + "'";
            MessageBox.Show(SelectCmd);
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader = Cmd.ExecuteReader();
            //��ܸ�ƪ���쪺�Ҧ����
            if (reader.Read())
            {
                TextBox1.Text = "�ǡ@�@���G " + reader["�Ǹ�"].ToString() + "\n";
                TextBox1.Text += "�m�@�@�W�G " + reader["�m�W"].ToString() + "\n";
                TextBox1.Text += "��  ��  �w�G " + reader["��Ʈw"].ToString() + "\n";
                TextBox1.Text += "��Ƶ��c�G " + reader["��Ƶ��c"].ToString() + "\n";
                TextBox1.Text += "�{���]�p�G " + reader["�{���]�p"].ToString();

            }
            else
                MessageBox.Show("�䤣�즹��ǥͪ����Z�O���I");
            conn.Close();                       //������Ʈw
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string Stu_Name = textBox3.Text;
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "select * from �ǥͦ��Z�� Where �m�W='" + Stu_Name + "'";
            MessageBox.Show(SelectCmd);
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader = Cmd.ExecuteReader();
            //��ܸ�ƪ���쪺�Ҧ����
            if (reader.Read())
            {
                TextBox1.Text = "�ǡ@�@���G " + reader["�Ǹ�"].ToString() + "\n";
                TextBox1.Text +="�m�@�@�W�G " + reader["�m�W"].ToString() + "\n";
                TextBox1.Text += "��  ��  �w�G " + reader["��Ʈw"].ToString() + "\n";
                TextBox1.Text += "��Ƶ��c�G " + reader["��Ƶ��c"].ToString() + "\n";
                TextBox1.Text += "�{���]�p�G " + reader["�{���]�p"].ToString();

            }
            else
                MessageBox.Show("�䤣�즹��ǥͪ����Z�O���I");
            conn.Close();                       //������Ʈw
        }
    }
}