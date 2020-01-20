using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ch19_3._A
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string ID= textBox2.Text;
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "select * from 學生成績表 Where 學號='" + ID + "'";
            MessageBox.Show(SelectCmd);
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader = Cmd.ExecuteReader();
            //顯示資料表欄位的所有資料
            if (reader.Read())
            {
                TextBox1.Text = "學　　號： " + reader["學號"].ToString() + "\n";
                TextBox1.Text += "姓　　名： " + reader["姓名"].ToString() + "\n";
                TextBox1.Text += "資  料  庫： " + reader["資料庫"].ToString() + "\n";
                TextBox1.Text += "資料結構： " + reader["資料結構"].ToString() + "\n";
                TextBox1.Text += "程式設計： " + reader["程式設計"].ToString();

            }
            else
                MessageBox.Show("找不到此位學生的成績記錄！");
            conn.Close();                       //關閉資料庫
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string Stu_Name = textBox3.Text;
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "select * from 學生成績表 Where 姓名='" + Stu_Name + "'";
            MessageBox.Show(SelectCmd);
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader = Cmd.ExecuteReader();
            //顯示資料表欄位的所有資料
            if (reader.Read())
            {
                TextBox1.Text = "學　　號： " + reader["學號"].ToString() + "\n";
                TextBox1.Text +="姓　　名： " + reader["姓名"].ToString() + "\n";
                TextBox1.Text += "資  料  庫： " + reader["資料庫"].ToString() + "\n";
                TextBox1.Text += "資料結構： " + reader["資料結構"].ToString() + "\n";
                TextBox1.Text += "程式設計： " + reader["程式設計"].ToString();

            }
            else
                MessageBox.Show("找不到此位學生的成績記錄！");
            conn.Close();                       //關閉資料庫
        }
    }
}