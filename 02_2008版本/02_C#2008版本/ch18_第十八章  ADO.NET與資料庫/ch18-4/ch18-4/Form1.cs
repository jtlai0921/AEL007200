using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace ch18_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";       //宣告資料庫所在的路徑變數
            string Source;                    //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;              //宣告連線的物件
            conn = new OleDbConnection(Source);      //連線
            conn.Open();                             //開啟資料庫
            string SelectCmd = "select 學號,姓名,系名 from 學生資料表,科系代碼資料表 where 學生資料表.系碼=科系代碼資料表.系碼";
            OleDbCommand Cmd;
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
    }
}