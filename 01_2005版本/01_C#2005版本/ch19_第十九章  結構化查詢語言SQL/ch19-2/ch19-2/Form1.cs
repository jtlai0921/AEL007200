using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch19_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";    //宣告資料庫所在的路徑變數
            string Source;                 //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;          //宣告連線的物件
            conn = new OleDbConnection(Source);   //連線
            conn.Open();          //開啟資料庫
            string CreateCmd;
            CreateCmd = "Create Table 學生表(學號 char(8),姓名 char(4),電話 char(12),地址 char(50))";
            OleDbCommand Cmd = new OleDbCommand(CreateCmd, conn);
            Cmd.ExecuteNonQuery();
            conn.Close();         //關閉資料庫
            MessageBox.Show("建立「新資料表」成功！");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";    //宣告資料庫所在的路徑變數
            string Source;                 //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;          //宣告連線的物件
            conn = new OleDbConnection(Source);   //連線
            conn.Open();          //開啟資料庫
            string AlterCmd;
            AlterCmd = "Alter Table 學生表 Add primary key(學號)";
            OleDbCommand Cmd = new OleDbCommand(AlterCmd, conn);
            Cmd.ExecuteNonQuery();
            conn.Close();         //關閉資料庫
            MessageBox.Show("設定「主鍵」成功！");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";    //宣告資料庫所在的路徑變數
            string Source;                 //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;          //宣告連線的物件
            conn = new OleDbConnection(Source);   //連線
            conn.Open();          //開啟資料庫
            string AlterCmd;
            AlterCmd = "Alter Table 學生表 Add 系碼 char(4)";
            OleDbCommand Cmd = new OleDbCommand(AlterCmd, conn);
            Cmd.ExecuteNonQuery();
            conn.Close();         //關閉資料庫
            MessageBox.Show("「增加欄位」成功！");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";    //宣告資料庫所在的路徑變數
            string Source;                 //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;          //宣告連線的物件
            conn = new OleDbConnection(Source);   //連線
            conn.Open();          //開啟資料庫
            string AlterCmd;
            AlterCmd = "Alter Table 學生表 Alter 地址 char(100)";
            OleDbCommand Cmd = new OleDbCommand(AlterCmd, conn);
            Cmd.ExecuteNonQuery();
            conn.Close();         //關閉資料庫
            MessageBox.Show("修改欄位「資料型態」成功！");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";    //宣告資料庫所在的路徑變數
            string Source;                 //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;          //宣告連線的物件
            conn = new OleDbConnection(Source);   //連線
            conn.Open();          //開啟資料庫
            string AlterCmd;
            AlterCmd = "Alter Table 學生表 Drop 電話";
            OleDbCommand Cmd = new OleDbCommand(AlterCmd, conn);
            Cmd.ExecuteNonQuery();
            conn.Close();         //關閉資料庫
            MessageBox.Show("「刪除欄位」成功！");
        }
    }
}