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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            // =====�d�߾ǥͿ�Ҭ�زM��==========
            string str1 = comboBox1.Text.Trim();
            string SelectCmd = "select �ǥ͸�ƪ�.�Ǹ�,�m�W,�ҦW,�Ǥ��� from ��t�N�X��ƪ�,�ǥ͸�ƪ�,��Ҹ�ƪ�,�ҵ{��ƪ� where �ǥ͸�ƪ�.�t�X=��t�N�X��ƪ�.�t�X And �ǥ͸�ƪ�.�Ǹ�=��Ҹ�ƪ�.�Ǹ� And ��Ҹ�ƪ�.�Ҹ�=�ҵ{��ƪ�.�Ҹ� And ��Ҹ�ƪ�.�Ǹ�='" + str1.Substring(0, 5) + "'";
            //�ŧi����
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //Ū����ƪ�
            DtApter.Fill(DtSet, "�ǥ͸�ƪ�");
            dataGridView1.DataSource = DtSet.Tables["�ǥ͸�ƪ�"];
            conn.Close();                       // ������Ʈw
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "select * from �ǥ͸�ƪ�";
            OleDbCommand cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();
            //��ܸ�ƪ���쪺�Ҧ����
            while (reader.Read())
                comboBox1.Items.Add(reader["�Ǹ�"] + "/" + reader["�m�W"]);
            conn.Close();                       // ������Ʈw
        }
    }
}