using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ch20_1A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                string dbpath = "DBMS1.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
                string Source;                             //�ŧi�s�u���r��
                Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
                OleDbConnection conn;                      //�ŧi�s�u������
                conn = new OleDbConnection(Source);        //�s�u
                conn.Open();                               //�}�Ҹ�Ʈw
                string SelectCmd = TextBox1.Text;
                //�ŧi����
                OleDbDataAdapter DtApter;
                DataSet DtSet;
                DtApter = new OleDbDataAdapter(SelectCmd, conn);
                DtSet = new DataSet();
                //Ū����ƪ�
                DtApter.Fill(DtSet, "Table");
                DataGridView1.DataSource = DtSet.Tables["Table"];
                conn.Close();                       // ������Ʈw
            }
            else
                MessageBox.Show("�z�|�����gSQL���O�I");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                string dbpath = "DBMS2.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
                string Source;                             //�ŧi�s�u���r��
                Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
                OleDbConnection conn;                      //�ŧi�s�u������
                conn = new OleDbConnection(Source);        //�s�u
                conn.Open();                               //�}�Ҹ�Ʈw
                string SelectCmd = TextBox1.Text;
                //�ŧi����
                OleDbDataAdapter DtApter;
                DataSet DtSet;
                DtApter = new OleDbDataAdapter(SelectCmd, conn);
                DtSet = new DataSet();
                //Ū����ƪ�
                DtApter.Fill(DtSet, "Table");
                DataGridView1.DataSource = DtSet.Tables["Table"];
                conn.Close();                       // ������Ʈw
            }
            else
                MessageBox.Show("�z�|�����gSQL���O�I");
        }
    }
}