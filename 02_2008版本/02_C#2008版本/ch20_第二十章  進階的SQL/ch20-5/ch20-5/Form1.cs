using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ch20_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
                string Source;                             //宣告連線的字串
                Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
                OleDbConnection conn;                      //宣告連線的物件
                conn = new OleDbConnection(Source);        //連線
                conn.Open();                               //開啟資料庫
                string SelectCmd = TextBox1.Text;
                //宣告物件
                OleDbDataAdapter DtApter;
                DataSet DtSet;
                DtApter = new OleDbDataAdapter(SelectCmd, conn);
                DtSet = new DataSet();
                //讀取資料表
                DtApter.Fill(DtSet, "Table");
                DataGridView1.DataSource = DtSet.Tables["Table"];
                conn.Close();                       // 關閉資料庫
            }
            else
                MessageBox.Show("您尚未撰寫SQL指令！");
        }
    }
}