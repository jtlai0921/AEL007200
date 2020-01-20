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
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "select * from 科系代碼資料表 order by 系碼 ASC";
            //宣告物件
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //讀取資料表
            DtApter.Fill(DtSet, "科系代碼資料表");
            dataGridView1.DataSource = DtSet.Tables["科系代碼資料表"];
            conn.Close();                       // 關閉資料庫
            label5.Visible = false;
            label6.Visible = false;
            textBox4.Visible = false;
            button5.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {//查詢
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
        {//新增
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string InsertCmd;
            InsertCmd = "Insert Into 科系代碼資料表(系碼,系名,系主任) Values('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "')";
            OleDbCommand cmd = new OleDbCommand(InsertCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();                              // 關閉資料庫
            MessageBox.Show("新增成功！");
            Show_Record();
        }

        private void Button3_Click(object sender, EventArgs e)
        { //修改
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string UpdateCmd;
            UpdateCmd = "UPDATE 科系代碼資料表 SET 系碼='" + textBox1.Text.Trim() + "',系名='" + textBox2.Text.Trim() + "' ,系主任='" + textBox3.Text.Trim() + "' WHERE 系碼='" + textBox1.Text.Trim() + "'";
            OleDbCommand cmd = new OleDbCommand(UpdateCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("修改成功！");
            Show_Record();
        }

        private void Button4_Click(object sender, EventArgs e)
        {//刪除
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string DeleteCmd;
            DeleteCmd = "Delete From 科系代碼資料表 WHERE 系碼='" + textBox1.Text.Trim() + "'";
            OleDbCommand cmd = new OleDbCommand(DeleteCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("刪除成功！");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            Show_Record();
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
            SelectCmd = "Select * From 科系代碼資料表 Where 系碼='" + textBox4.Text.Trim() + "'";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader;
            reader = Cmd.ExecuteReader();
            //顯示資料表欄位的所有資料
            while (reader.Read())
            {
                textBox1.Text = reader["系碼"].ToString();
                textBox2.Text = reader["系名"].ToString();
                textBox3.Text = reader["系主任"].ToString();
            }
            conn.Close();                       // 關閉資料庫

        }
    }
}