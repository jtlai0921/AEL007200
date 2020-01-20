using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ch19_5._
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "select * from �ǥͦ��Z��";
            //�ŧi����
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //Ū����ƪ�
            DtApter.Fill(DtSet, "�ǥͦ��Z��");
            DataGridView1.DataSource = DtSet.Tables["�ǥͦ��Z��"];
            conn.Close();                       // ������Ʈw
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "select COUNT(*) from �ǥͦ��Z��";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
             //��ܸ�ƪ���쪺�Ҧ����
            Label1.Text = "�ǥͦ��Z��@" + Cmd.ExecuteScalar() + " ���O��";
            conn.Close();                             // ������Ʈw
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "select SUM(��Ʈw) from �ǥͦ��Z��";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //��ܸ�ƪ���쪺�Ҧ����
            Label2.Text = "��Ʈw�`���Z " + Cmd.ExecuteScalar() + " ��";
            conn.Close();                             // ������Ʈw
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "select AVG(��Ʈw) from �ǥͦ��Z��";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //��ܸ�ƪ���쪺�Ҧ����
            Label3.Text = "��Ʈw�������Z " + Cmd.ExecuteScalar() + " ��";
            conn.Close();                             // ������Ʈw
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "select MAX(��Ʈw) from �ǥͦ��Z��";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //��ܸ�ƪ���쪺�Ҧ����
            Label4.Text = "��Ʈw�̰��� " + Cmd.ExecuteScalar() + " ��";
            conn.Close();                             // ������Ʈw
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "select MIN(��Ʈw) from �ǥͦ��Z��";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //��ܸ�ƪ���쪺�Ҧ����
            Label5.Text = "��Ʈw�̧C�� " + Cmd.ExecuteScalar() + " ��";
            conn.Close();                             // ������Ʈw
        }
    }
}