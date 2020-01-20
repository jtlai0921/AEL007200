using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ch19_5._A
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

        void clear()
        {
          Label1.Text = "";
          Label2.Text = "";
          Label3.Text = "";
          Label4.Text = "";
          Label5.Text = "";
          CheckBox1.Checked = false;
          CheckBox2.Checked = false;
          CheckBox3.Checked = false;
          CheckBox4.Checked = false;
          CheckBox5.Checked = false;
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
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
           if (CheckBox1.Checked ==true) 
            Label1.Text = "�ǥͦ��Z��@" + Cmd.ExecuteScalar() + " ���O��";
           else
            Label1.Text = "";
            conn.Close();                             // ������Ʈw
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "";
            string Temp = "";
            if (RadioButton1.Checked == true)         //�I����
            {
              Temp = "��Ʈw";
              SelectCmd = "select SUM(��Ʈw) from �ǥͦ��Z��";
            }
            else if (RadioButton2.Checked == true)      //�I��^��
            {
              Temp = "��Ƶ��c";
              SelectCmd = "select SUM(��Ƶ��c) from �ǥͦ��Z��";
            }
            else if (RadioButton3.Checked == true)       //�I��ƾ�
            {
                Temp = "�{���]�p";
                SelectCmd = "select SUM(�{���]�p) from �ǥͦ��Z��";
            }
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //��ܸ�ƪ���쪺�Ҧ����
            if (CheckBox2.Checked == true)
                Label2.Text = Temp + "�`���Z " + Cmd.ExecuteScalar() + " ��";
            else
                Label2.Text = "";
            conn.Close();                             // ������Ʈw
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "";
            string Temp = "";
            if (RadioButton1.Checked == true)         //�I����
            {
                Temp = "��Ʈw";
                SelectCmd = "select AVG(��Ʈw) from �ǥͦ��Z��";
            }
            else if (RadioButton2.Checked == true)      //�I��^��
            {
                Temp = "��Ƶ��c";
                SelectCmd = "select AVG(��Ƶ��c) from �ǥͦ��Z��";
            }
            else if (RadioButton3.Checked == true)       //�I��ƾ�
            {
                Temp = "�{���]�p";
                SelectCmd = "select AVG(�{���]�p) from �ǥͦ��Z��";
            }
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //��ܸ�ƪ���쪺�Ҧ����
            if (CheckBox3.Checked == true)
                Label3.Text = Temp + "�������Z " + Cmd.ExecuteScalar() + " ��";
            else
                Label3.Text = "";
            conn.Close();                             // ������Ʈw
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "";
            string Temp = "";
            if (RadioButton1.Checked == true)         //�I����
            {
                Temp = "��Ʈw";
                SelectCmd = "select MAX(��Ʈw) from �ǥͦ��Z��";
            }
            else if (RadioButton2.Checked == true)      //�I��^��
            {
                Temp = "��Ƶ��c";
                SelectCmd = "select MAX(��Ƶ��c) from �ǥͦ��Z��";
            }
            else if (RadioButton3.Checked == true)       //�I��ƾ�
            {
                Temp = "�{���]�p";
                SelectCmd = "select MAX(�{���]�p) from �ǥͦ��Z��";
            }
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //��ܸ�ƪ���쪺�Ҧ����
            if (CheckBox4.Checked == true)
                Label4.Text = Temp + "�̰��� " + Cmd.ExecuteScalar() + " ��";
            else
                Label4.Text = "";
            conn.Close();                             // ������Ʈw
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "";
            string Temp = "";
            if (RadioButton1.Checked == true)         //�I����
            {
                Temp = "��Ʈw";
                SelectCmd = "select MIN(��Ʈw) from �ǥͦ��Z��";
            }
            else if (RadioButton2.Checked == true)      //�I��^��
            {
                Temp = "��Ƶ��c";
                SelectCmd = "select MIN(��Ƶ��c) from �ǥͦ��Z��";
            }
            else if (RadioButton3.Checked == true)       //�I��ƾ�
            {
                Temp = "�{���]�p";
                SelectCmd = "select MIN(�{���]�p) from �ǥͦ��Z��";
            }
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //��ܸ�ƪ���쪺�Ҧ����
            if (CheckBox5.Checked == true)
                Label5.Text = Temp + "�̧C�� " + Cmd.ExecuteScalar() + " ��";
            else
                Label5.Text = "";
            conn.Close();                             // ������Ʈw
        }
    }
}