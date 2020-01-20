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
    public partial class Form3 : Form
    {
        public Form3()
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
            DtApter.Fill(DtSet, "Student");
            dataGridView1.DataSource = DtSet.Tables["Student"];
            conn.Close();                       // ������Ʈw
            label5.Visible = false;
            label6.Visible = false;
            textBox3.Visible = false;
            button7.Visible = false;
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
            OleDbCommand cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();
            //��ܸ�ƪ���쪺�Ҧ����
            while (reader.Read())
                comboBox1.Items.Add(reader["�t�X"] + "/" + reader["�t�W"]);
            conn.Close();                       // ������Ʈw
        }

        void Display_Dept_No_Name()
        {
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd = "select ��t�N�X��ƪ�.�t�X,�t�W from ��t�N�X��ƪ�,�ǥ͸�ƪ� where ��t�N�X��ƪ�.�t�X=�ǥ͸�ƪ�.�t�X And �Ǹ�='" + textBox3.Text.Trim() + "'";
            OleDbCommand cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();
            //��ܸ�ƪ���쪺�Ҧ����
            if(reader.Read())
                comboBox1.Text=reader["�t�X"] + "/" + reader["�t�W"];
            conn.Close();                       // ������Ʈw
        }


        private void button1_Click(object sender, EventArgs e)
        {//�d��
            label5.Visible = true;
            label6.Visible = true;
            textBox3.Visible = true;
            button7.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {//�s�W
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string InsertCmd;
            string str1 = comboBox1.Text.Trim();
            InsertCmd = "Insert Into �ǥ͸�ƪ�(�Ǹ�,�m�W,�t�X) Values('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + str1.Substring(0, 4) + "')";
            OleDbCommand cmd = new OleDbCommand(InsertCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();                              // ������Ʈw
            MessageBox.Show("�s�W���\�I");
            Show_Record();

        }

        private void button3_Click(object sender, EventArgs e)
        { //�ק�
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string UpdateCmd;
            string str1 = comboBox1.Text.Trim();
            UpdateCmd = "UPDATE �ǥ͸�ƪ� SET �Ǹ�='" + textBox1.Text.Trim() + "',�m�W='" + textBox2.Text.Trim() + "' ,�t�X='" + str1.Substring(0, 4) + "' WHERE �Ǹ�='" + textBox1.Text.Trim() + "'";
            OleDbCommand cmd = new OleDbCommand(UpdateCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("�ק令�\�I");
            Show_Record();

        }

        private void button4_Click(object sender, EventArgs e)
        {//�R��
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string DeleteCmd;
            DeleteCmd = "Delete From �ǥ͸�ƪ� WHERE �Ǹ�='" + textBox1.Text.Trim() + "'";
            OleDbCommand cmd = new OleDbCommand(DeleteCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("�R�����\�I");
            textBox1.Clear();
            textBox2.Clear();
            Show_Record();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Show_Record();
            Show_Dept_No();
        }

        private void button7_Click(object sender, EventArgs e)
        {//�d��(Go)
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string SelectCmd;
            SelectCmd = "Select * From �ǥ͸�ƪ� Where �Ǹ�='" + textBox3.Text.Trim() + "'";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader;
            reader = Cmd.ExecuteReader();
            //��ܸ�ƪ���쪺�Ҧ����
            while (reader.Read())
            {
                textBox1.Text = reader["�Ǹ�"].ToString();
                textBox2.Text = reader["�m�W"].ToString();
            }
            Display_Dept_No_Name();
            conn.Close();                       // ������Ʈw
        }

        private void button5_Click(object sender, EventArgs e)
        {
          if (textBox1.Text == "")
            MessageBox.Show("�z�|����J�Ǹ��I");
          else
          {
            Form4 ShowForm = new Form4();   //�إ�Form4����
            ShowForm.Show();                //���MDI���l���
            ShowForm.label1.Text = "�Ǹ��G" + this.textBox1.Text + "  �m�W�G" + this.textBox2.Text;
          }
        }
    }
}