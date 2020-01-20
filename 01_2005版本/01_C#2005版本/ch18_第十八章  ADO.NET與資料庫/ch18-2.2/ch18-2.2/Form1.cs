using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace ch18_2._
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";    //宣告資料庫所在的路徑變數
            string Source;                 //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;          //宣告連線的物件
            conn = new OleDbConnection(Source);   //連線
            conn.Open();          //開啟資料庫
            MessageBox.Show("成功連結到Access資料庫");
            conn.Close();         //關閉資料庫
        }
    }
}