using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace ch18_3._A
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
            //顯示資料表欄位的所有資料
            int i;
            while (reader.Read())
            {
                for (i = 0; i <= reader.FieldCount - 1; i++)
                {
                    textBox1.Text += reader.GetValue(i) + "\t";
                }
                textBox1.Text += "\n";
            }
            conn.Close();         //關閉資料庫
        }
    }
}