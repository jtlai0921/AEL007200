using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ch19_5._A
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

        void clear()
        {
          Label1.Text = "";
          Label2.Text = "";
          Label3.Text = "";
          Label4.Text = "";
          Label5.Text = "";
          CheckBox1.Checked = false;
          CheckBox2.Checked = false;
          CheckBox3.Checked = false;
          CheckBox4.Checked = false;
          CheckBox5.Checked = false;
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
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
           if (CheckBox1.Checked ==true) 
            Label1.Text = "學生成績表共" + Cmd.ExecuteScalar() + " 筆記錄";
           else
            Label1.Text = "";
            conn.Close();                             // 關閉資料庫
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "";
            string Temp = "";
            if (RadioButton1.Checked == true)         //點選國文
            {
              Temp = "資料庫";
              SelectCmd = "select SUM(資料庫) from 學生成績表";
            }
            else if (RadioButton2.Checked == true)      //點選英文
            {
              Temp = "資料結構";
              SelectCmd = "select SUM(資料結構) from 學生成績表";
            }
            else if (RadioButton3.Checked == true)       //點選數學
            {
                Temp = "程式設計";
                SelectCmd = "select SUM(程式設計) from 學生成績表";
            }
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //顯示資料表欄位的所有資料
            if (CheckBox2.Checked == true)
                Label2.Text = Temp + "總成績 " + Cmd.ExecuteScalar() + " 分";
            else
                Label2.Text = "";
            conn.Close();                             // 關閉資料庫
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "";
            string Temp = "";
            if (RadioButton1.Checked == true)         //點選國文
            {
                Temp = "資料庫";
                SelectCmd = "select AVG(資料庫) from 學生成績表";
            }
            else if (RadioButton2.Checked == true)      //點選英文
            {
                Temp = "資料結構";
                SelectCmd = "select AVG(資料結構) from 學生成績表";
            }
            else if (RadioButton3.Checked == true)       //點選數學
            {
                Temp = "程式設計";
                SelectCmd = "select AVG(程式設計) from 學生成績表";
            }
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //顯示資料表欄位的所有資料
            if (CheckBox3.Checked == true)
                Label3.Text = Temp + "平均成績 " + Cmd.ExecuteScalar() + " 分";
            else
                Label3.Text = "";
            conn.Close();                             // 關閉資料庫
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "";
            string Temp = "";
            if (RadioButton1.Checked == true)         //點選國文
            {
                Temp = "資料庫";
                SelectCmd = "select MAX(資料庫) from 學生成績表";
            }
            else if (RadioButton2.Checked == true)      //點選英文
            {
                Temp = "資料結構";
                SelectCmd = "select MAX(資料結構) from 學生成績表";
            }
            else if (RadioButton3.Checked == true)       //點選數學
            {
                Temp = "程式設計";
                SelectCmd = "select MAX(程式設計) from 學生成績表";
            }
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //顯示資料表欄位的所有資料
            if (CheckBox4.Checked == true)
                Label4.Text = Temp + "最高分 " + Cmd.ExecuteScalar() + " 分";
            else
                Label4.Text = "";
            conn.Close();                             // 關閉資料庫
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "";
            string Temp = "";
            if (RadioButton1.Checked == true)         //點選國文
            {
                Temp = "資料庫";
                SelectCmd = "select MIN(資料庫) from 學生成績表";
            }
            else if (RadioButton2.Checked == true)      //點選英文
            {
                Temp = "資料結構";
                SelectCmd = "select MIN(資料結構) from 學生成績表";
            }
            else if (RadioButton3.Checked == true)       //點選數學
            {
                Temp = "程式設計";
                SelectCmd = "select MIN(程式設計) from 學生成績表";
            }
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            //顯示資料表欄位的所有資料
            if (CheckBox5.Checked == true)
                Label5.Text = Temp + "最低分 " + Cmd.ExecuteScalar() + " 分";
            else
                Label5.Text = "";
            conn.Close();                             // 關閉資料庫
        }
    }
}