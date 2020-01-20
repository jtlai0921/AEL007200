using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ch19_5._
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "select * from 學生成績表";
            //宣告物件
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //讀取資料表
            DtApter.Fill(DtSet, "學生成績表");
            DataGridView1.DataSource = DtSet.Tables["學生成績表"];
            conn.Close();                       // 關閉資料庫
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "select COUNT(*) from 學生成績表";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
             //顯示資料表欄位的所有資料
            Label1.Text = "學生成績表共" + Cmd.ExecuteScalar() + " 筆記錄";
            conn.Close();                             // 關閉資料庫
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "select SUM(資料庫) from 學生成績表";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //顯示資料表欄位的所有資料
            Label2.Text = "資料庫總成績 " + Cmd.ExecuteScalar() + " 分";
            conn.Close();                             // 關閉資料庫
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "select AVG(資料庫) from 學生成績表";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //顯示資料表欄位的所有資料
            Label3.Text = "資料庫平均成績 " + Cmd.ExecuteScalar() + " 分";
            conn.Close();                             // 關閉資料庫
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "select MAX(資料庫) from 學生成績表";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //顯示資料表欄位的所有資料
            Label4.Text = "資料庫最高分 " + Cmd.ExecuteScalar() + " 分";
            conn.Close();                             // 關閉資料庫
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "select MIN(資料庫) from 學生成績表";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //顯示資料表欄位的所有資料
            Label5.Text = "資料庫最低分 " + Cmd.ExecuteScalar() + " 分";
            conn.Close();                             // 關閉資料庫
        }
    }
}