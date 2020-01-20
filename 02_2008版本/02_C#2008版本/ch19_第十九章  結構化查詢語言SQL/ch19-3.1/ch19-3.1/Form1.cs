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
            string SelectCmd = "select 學號,姓名,系名 from 學生資料表,科系代碼資料表 where 學生資料表.系碼=科系代碼資料表.系碼";
            //宣告物件
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //讀取資料表
            DtApter.Fill(DtSet, "學生資料表");
            DataGridView1.DataSource = DtSet.Tables["學生資料表"];
            conn.Close();                       // 關閉資料庫
        }
        void Show_Dept_No()
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "select * from 科系代碼資料表";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader= Cmd.ExecuteReader();
           //顯示資料表欄位的所有資料
            while (reader.Read())
            ComboBox1.Items.Add(reader["系碼"] + "/" + reader["系名"]);
           conn.Close();                       //關閉資料庫
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string str1=ComboBox1.Text.Trim();
            string InsertCmd = "Insert Into 學生資料表(學號,姓名,系碼) Values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + str1.Substring(0,4) + "')";
            OleDbCommand Cmd = new OleDbCommand(InsertCmd, conn);
            Cmd.ExecuteNonQuery();
            conn.Close();                             // 關閉資料庫
            MessageBox.Show ("新增成功！");
            Show_Record();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show_Record();
            Show_Dept_No();
        }
    }
}