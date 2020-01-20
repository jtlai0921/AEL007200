using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ch20_3
{
    public partial class Form1 : Form
    {
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
            string SelectCmd = "select * from ��t�N�X��ƪ� order by �t�X ASC";
            //�ŧi����
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //Ū����ƪ�
            DtApter.Fill(DtSet, "��t�N�X��ƪ�");
            dataGridView1.DataSource = DtSet.Tables["��t�N�X��ƪ�"];
            conn.Close();                       // ������Ʈw
            label5.Visible = false;
            label6.Visible = false;
            textBox4.Visible = false;
            button5.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {//�d��
            label5.Visible = true;
            label6.Visible = true;
            textBox4.Visible = true;
            button5.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show_Record();

        }

        private void Button2_Click(object sender, EventArgs e)
        {//�s�W
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string InsertCmd;
            InsertCmd = "Insert Into ��t�N�X��ƪ�(�t�X,�t�W,�t�D��) Values('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "')";
            OleDbCommand cmd = new OleDbCommand(InsertCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();                              // ������Ʈw
            MessageBox.Show("�s�W���\�I");
            Show_Record();
        }

        private void Button3_Click(object sender, EventArgs e)
        { //�ק�
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string UpdateCmd;
            UpdateCmd = "UPDATE ��t�N�X��ƪ� SET �t�X='" + textBox1.Text.Trim() + "',�t�W='" + textBox2.Text.Trim() + "' ,�t�D��='" + textBox3.Text.Trim() + "' WHERE �t�X='" + textBox1.Text.Trim() + "'";
            OleDbCommand cmd = new OleDbCommand(UpdateCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("�ק令�\�I");
            Show_Record();
        }

        private void Button4_Click(object sender, EventArgs e)
        {//�R��
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string DeleteCmd;
            DeleteCmd = "Delete From ��t�N�X��ƪ� WHERE �t�X='" + textBox1.Text.Trim() + "'";
            OleDbCommand cmd = new OleDbCommand(DeleteCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("�R�����\�I");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            Show_Record();
        }

        private void button5_Click(object sender, EventArgs e)
        {//�d��(Go)
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd;
            SelectCmd = "Select * From ��t�N�X��ƪ� Where �t�X='" + textBox4.Text.Trim() + "'";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader;
            reader = Cmd.ExecuteReader();
            //��ܸ�ƪ���쪺�Ҧ����
            while (reader.Read())
            {
                textBox1.Text = reader["�t�X"].ToString();
                textBox2.Text = reader["�t�W"].ToString();
                textBox3.Text = reader["�t�D��"].ToString();
            }
            conn.Close();                       // ������Ʈw

        }
    }
}