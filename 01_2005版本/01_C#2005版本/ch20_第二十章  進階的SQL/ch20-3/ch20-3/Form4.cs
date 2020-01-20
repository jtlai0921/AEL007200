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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Temp = "";
            int intIndex;
            for (intIndex = 0; intIndex <= checkedListBox1.Items.Count - 1; intIndex++)
            {
                if (checkedListBox1.GetItemChecked(intIndex) == true)
                    Temp += checkedListBox1.Items[intIndex].ToString() + "\n";
            }
            textBox1.Text = Temp;

        }

        private void Form4_Load(object sender, EventArgs e)
        {//�d��(Go)
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd;
            SelectCmd = "Select * From �ҵ{��ƪ� ";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader;
            reader = Cmd.ExecuteReader();
            //��ܸ�ƪ���쪺�Ҧ����
            while (reader.Read())
                checkedListBox1.Items.Add(reader["�Ҹ�"].ToString() + "/" + reader["�ҦW"].ToString());
            conn.Close();                       // ������Ʈw
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            string InsertCmd;
            int intIndex;
            for (intIndex = 0; intIndex <= checkedListBox1.Items.Count - 1; intIndex++)
            {
                if (checkedListBox1.GetItemChecked(intIndex) == true)
                {
                    OleDbConnection conn;                      //�ŧi�s�u������
                    conn = new OleDbConnection(Source);        //�s�u
                    conn.Open();                               //�}�Ҹ�Ʈw
                    string str1 = label1.Text.Trim();
                    string str2 = checkedListBox1.Items[intIndex].ToString();
                    InsertCmd = "Insert Into ��Ҹ�ƪ�(�Ǹ�,�Ҹ�) Values('" + str1.Substring(3, 5) + "','" + str2.Substring(0, 4) + "')";
                    OleDbCommand cmd = new OleDbCommand(InsertCmd, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();                              // ������Ʈw
                    MessageBox.Show("�[�令�\�I");
                }
            }
        }
    }
}