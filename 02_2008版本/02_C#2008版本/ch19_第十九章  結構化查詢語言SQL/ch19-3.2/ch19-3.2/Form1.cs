using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ch19_3._
{
    public partial class Form1 : Form
    {
        string ID;
        public Form1()
        {   
            InitializeComponent();
        }
        void Show_Record()
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "select �Ǹ�,�m�W,�t�W from �ǥ͸�ƪ�,��t�N�X��ƪ� where �ǥ͸�ƪ�.�t�X=��t�N�X��ƪ�.�t�X";
            //�ŧi����
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //Ū����ƪ�
            DtApter.Fill(DtSet, "�ǥ͸�ƪ�");
            DataGridView1.DataSource = DtSet.Tables["�ǥ͸�ƪ�"];
            conn.Close();                       // ������Ʈw
        }
        void Show_Dept_No()
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "select * from ��t�N�X��ƪ�";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader = Cmd.ExecuteReader();
            //��ܸ�ƪ���쪺�Ҧ����
            while (reader.Read())
                ComboBox1.Items.Add(reader["�t�X"] + "/" + reader["�t�W"]);
            conn.Close();                       //������Ʈw
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            ID = TextBox1.Text;
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd;
            SelectCmd = "select * from �ǥ͸�ƪ� Where �Ǹ�='" + ID + "'";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader = Cmd.ExecuteReader();
            //��ܸ�ƪ���쪺�Ҧ����
            while (reader.Read())
            {
                TextBox1.Text = reader["�Ǹ�"].ToString();
                TextBox2.Text = reader["�m�W"].ToString();
            }
            conn.Close();                       //������Ʈw
        }

        void Display_Dept_No_Name()
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd;
            SelectCmd = "select ��t�N�X��ƪ�.�t�X,�t�W from ��t�N�X��ƪ�,�ǥ͸�ƪ� where ��t�N�X��ƪ�.�t�X=�ǥ͸�ƪ�.�t�X And �Ǹ�='" + ID + "'";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader = Cmd.ExecuteReader();
            //��ܸ�ƪ���쪺�Ҧ����
            while (reader.Read())
                ComboBox1.Items.Add(reader["�t�X"] + "/" + reader["�t�W"]);
            conn.Close();                       //������Ʈw
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string str1 = ComboBox1.Text.Trim();
            string InsertCmd = "Insert Into �ǥ͸�ƪ�(�Ǹ�,�m�W,�t�X) Values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + str1.Substring(0, 4) + "')";
            OleDbCommand Cmd = new OleDbCommand(InsertCmd, conn);
            Cmd.ExecuteNonQuery();
            conn.Close();                             // ������Ʈw
            MessageBox.Show("�s�W���\�I");
            Show_Record();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string str1 = ComboBox1.Text.Trim();
            string UpdateCmd = "UPDATE �ǥ͸�ƪ� SET �Ǹ�='" + TextBox1.Text.Trim() + "',�m�W='" + TextBox2.Text.Trim() + "' ,�t�X='" + str1.Substring(0, 4) + "' WHERE �Ǹ�='" + TextBox1.Text.Trim() + "'";
            OleDbCommand Cmd = new OleDbCommand(UpdateCmd, conn);
            Cmd.ExecuteNonQuery();
            conn.Close();                             // ������Ʈw
            MessageBox.Show("�ק令�\�I");
            Show_Record();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show_Record();
            Show_Dept_No();
        }
    }
}