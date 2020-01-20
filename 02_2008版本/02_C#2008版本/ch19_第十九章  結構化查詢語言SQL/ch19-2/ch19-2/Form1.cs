using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch19_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";    //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                 //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;          //�ŧi�s�u������
            conn = new OleDbConnection(Source);   //�s�u
            conn.Open();          //�}�Ҹ�Ʈw
            string CreateCmd;
            CreateCmd = "Create Table �ǥͪ�(�Ǹ� char(8),�m�W char(4),�q�� char(12),�a�} char(50))";
            OleDbCommand Cmd = new OleDbCommand(CreateCmd, conn);
            Cmd.ExecuteNonQuery();
            conn.Close();         //������Ʈw
            MessageBox.Show("�إߡu�s��ƪ�v���\�I");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";    //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                 //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;          //�ŧi�s�u������
            conn = new OleDbConnection(Source);   //�s�u
            conn.Open();          //�}�Ҹ�Ʈw
            string AlterCmd;
            AlterCmd = "Alter Table �ǥͪ� Add primary key(�Ǹ�)";
            OleDbCommand Cmd = new OleDbCommand(AlterCmd, conn);
            Cmd.ExecuteNonQuery();
            conn.Close();         //������Ʈw
            MessageBox.Show("�]�w�u�D��v���\�I");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";    //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                 //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;          //�ŧi�s�u������
            conn = new OleDbConnection(Source);   //�s�u
            conn.Open();          //�}�Ҹ�Ʈw
            string AlterCmd;
            AlterCmd = "Alter Table �ǥͪ� Add �t�X char(4)";
            OleDbCommand Cmd = new OleDbCommand(AlterCmd, conn);
            Cmd.ExecuteNonQuery();
            conn.Close();         //������Ʈw
            MessageBox.Show("�u�W�[���v���\�I");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";    //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                 //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;          //�ŧi�s�u������
            conn = new OleDbConnection(Source);   //�s�u
            conn.Open();          //�}�Ҹ�Ʈw
            string AlterCmd;
            AlterCmd = "Alter Table �ǥͪ� Alter �a�} char(100)";
            OleDbCommand Cmd = new OleDbCommand(AlterCmd, conn);
            Cmd.ExecuteNonQuery();
            conn.Close();         //������Ʈw
            MessageBox.Show("�ק����u��ƫ��A�v���\�I");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";    //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                 //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;          //�ŧi�s�u������
            conn = new OleDbConnection(Source);   //�s�u
            conn.Open();          //�}�Ҹ�Ʈw
            string AlterCmd;
            AlterCmd = "Alter Table �ǥͪ� Drop �q��";
            OleDbCommand Cmd = new OleDbCommand(AlterCmd, conn);
            Cmd.ExecuteNonQuery();
            conn.Close();         //������Ʈw
            MessageBox.Show("�u�R�����v���\�I");
        }
    }
}