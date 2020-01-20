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
    public partial class Form2 : Form
    {
        public Form2()
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
            string SelectCmd = "select * from �ҵ{��ƪ� order by �Ҹ� ASC";
            //�ŧi����
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //Ū����ƪ�
            DtApter.Fill(DtSet, "�ҵ{��ƪ�");
            dataGridView1.DataSource = DtSet.Tables["�ҵ{��ƪ�"];
            conn.Close();                       // ������Ʈw
            label5.Visible = false;
            label6.Visible = false;
            textBox3.Visible = false;
            button5.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {//�d��
            label5.Visible = true;
            label6.Visible = true;
            textBox3.Visible = true;
            button5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {//�s�W
            string dbpath = "DBMS.mdb";                //�ŧi��Ʈw�Ҧb�����|�ܼ�
            string Source;                             //�ŧi�s�u���r��
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //�ŧi�s�u������
            conn = new OleDbConnection(Source);        //�s�u
            conn.Open();                               //�}�Ҹ�Ʈw
            string sp;
            string InsertCmd;
            if (radioButton1.Checked == true)
                sp = "��";
            else
                sp = "��";
            InsertCmd = "Insert Into �ҵ{��ƪ�(�Ҹ�,�ҦW,�Ǥ���,�����) Values('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + comboBox1.Text.Trim() + "','" + sp + "')";
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
            string sp;
            if (radioButton1.Checked == true)
                sp = "��";
            else
                sp = "��";
            UpdateCmd = "UPDATE �ҵ{��ƪ� SET �Ҹ�='" + textBox1.Text.Trim() + "',�ҦW='" + textBox2.Text.Trim() + "' ,�Ǥ���='" + comboBox1.Text.Trim() + "' ,�����='" + sp + "' WHERE �Ҹ�='" + textBox1.Text.Trim() + "'";
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
            DeleteCmd = "Delete From �ҵ{��ƪ� WHERE �Ҹ�='" + textBox1.Text.Trim() + "'";
            OleDbCommand cmd = new OleDbCommand(DeleteCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("�R�����\�I");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            Show_Record();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          Show_Record();
          comboBox1.Items.Add("1");
          comboBox1.Items.Add("2");
          comboBox1.Items.Add("3");
          comboBox1.Items.Add("4");
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
            SelectCmd = "Select * From �ҵ{��ƪ� Where �Ҹ�='" + textBox3.Text.Trim() + "'";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader;
            reader = Cmd.ExecuteReader();
            //��ܸ�ƪ���쪺�Ҧ����
            while (reader.Read())
            {
                textBox1.Text = reader["�Ҹ�"].ToString();
                textBox2.Text = reader["�ҦW"].ToString();
                comboBox1.Text = reader["�Ǥ���"].ToString();
                if (reader["�����"].ToString() == "��")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
            }
            conn.Close();                       // ������Ʈw
        }
    }
}