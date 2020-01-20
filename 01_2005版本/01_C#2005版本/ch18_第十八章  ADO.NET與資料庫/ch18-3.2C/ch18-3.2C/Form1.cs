using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ch18_3._C
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
            string SelectCmd = "select * from 學生資料表";
            OleDbCommand Cmd;
            Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader;
            reader = Cmd.ExecuteReader();
            int i;
            //顯示資料表欄位名稱
            for (i = 0; i <= reader.FieldCount - 1; i++)
            {
                if (i == 3)
                    textBox1.Text += reader.GetName(i) + "\t" + "\t";
                else
                    textBox1.Text += reader.GetName(i) + "\t";
            }
            textBox1.Text += "\n";

            //顯示資料表欄位的所有資料
            while (reader.Read())
            {
                textBox1.Text += reader["學號"] + "\t";
                textBox1.Text += reader["姓名"] + "\t";
                textBox1.Text += reader["系碼"] + "\t";
                textBox1.Text += "\n";
            }
            conn.Close();         //關閉資料庫
        }
    }
}