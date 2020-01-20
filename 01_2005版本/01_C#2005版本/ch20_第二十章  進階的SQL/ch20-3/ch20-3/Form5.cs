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
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            // =====查詢學生選課科目清單==========
            string str1 = comboBox1.Text.Trim();
            string SelectCmd = "select 學生資料表.學號,姓名,課名,學分數 from 科系代碼資料表,學生資料表,選課資料表,課程資料表 where 學生資料表.系碼=科系代碼資料表.系碼 And 學生資料表.學號=選課資料表.學號 And 選課資料表.課號=課程資料表.課號 And 選課資料表.學號='" + str1.Substring(0, 5) + "'";
            //宣告物件
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //讀取資料表
            DtApter.Fill(DtSet, "學生資料表");
            dataGridView1.DataSource = DtSet.Tables["學生資料表"];
            conn.Close();                       // 關閉資料庫
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "select * from 學生資料表";
            OleDbCommand cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();
            //顯示資料表欄位的所有資料
            while (reader.Read())
                comboBox1.Items.Add(reader["學號"] + "/" + reader["姓名"]);
            conn.Close();                       // 關閉資料庫
        }
    }
}