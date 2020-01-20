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
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "select * from 課程資料表 order by 課號 ASC";
            //宣告物件
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //讀取資料表
            DtApter.Fill(DtSet, "課程資料表");
            dataGridView1.DataSource = DtSet.Tables["課程資料表"];
            conn.Close();                       // 關閉資料庫
            label5.Visible = false;
            label6.Visible = false;
            textBox3.Visible = false;
            button5.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {//查詢
            label5.Visible = true;
            label6.Visible = true;
            textBox3.Visible = true;
            button5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {//新增
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string sp;
            string InsertCmd;
            if (radioButton1.Checked == true)
                sp = "必";
            else
                sp = "選";
            InsertCmd = "Insert Into 課程資料表(課號,課名,學分數,必選修) Values('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + comboBox1.Text.Trim() + "','" + sp + "')";
            OleDbCommand cmd = new OleDbCommand(InsertCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();                              // 關閉資料庫
            MessageBox.Show("新增成功！");
            Show_Record();
        }

        private void button3_Click(object sender, EventArgs e)
        { //修改
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string UpdateCmd;
            string sp;
            if (radioButton1.Checked == true)
                sp = "必";
            else
                sp = "選";
            UpdateCmd = "UPDATE 課程資料表 SET 課號='" + textBox1.Text.Trim() + "',課名='" + textBox2.Text.Trim() + "' ,學分數='" + comboBox1.Text.Trim() + "' ,必選修='" + sp + "' WHERE 課號='" + textBox1.Text.Trim() + "'";
            OleDbCommand cmd = new OleDbCommand(UpdateCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("修改成功！");
            Show_Record();

        }

        private void button4_Click(object sender, EventArgs e)
        {//刪除
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string DeleteCmd;
            DeleteCmd = "Delete From 課程資料表 WHERE 課號='" + textBox1.Text.Trim() + "'";
            OleDbCommand cmd = new OleDbCommand(DeleteCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("刪除成功！");
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
        {//查詢(Go)
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd;
            SelectCmd = "Select * From 課程資料表 Where 課號='" + textBox3.Text.Trim() + "'";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader;
            reader = Cmd.ExecuteReader();
            //顯示資料表欄位的所有資料
            while (reader.Read())
            {
                textBox1.Text = reader["課號"].ToString();
                textBox2.Text = reader["課名"].ToString();
                comboBox1.Text = reader["學分數"].ToString();
                if (reader["必選修"].ToString() == "必")
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
            conn.Close();                       // 關閉資料庫
        }
    }
}