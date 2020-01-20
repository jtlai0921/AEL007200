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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Temp = "";
            int intIndex;
            for (intIndex = 0; intIndex <= checkedListBox1.Items.Count - 1; intIndex++)
            {
                if (checkedListBox1.GetItemChecked(intIndex) == true)
                    Temp += checkedListBox1.Items[intIndex].ToString() + "\n";
            }
            textBox1.Text = Temp;

        }

        private void Form4_Load(object sender, EventArgs e)
        {//查詢(Go)
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd;
            SelectCmd = "Select * From 課程資料表 ";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader;
            reader = Cmd.ExecuteReader();
            //顯示資料表欄位的所有資料
            while (reader.Read())
                checkedListBox1.Items.Add(reader["課號"].ToString() + "/" + reader["課名"].ToString());
            conn.Close();                       // 關閉資料庫
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            string InsertCmd;
            int intIndex;
            for (intIndex = 0; intIndex <= checkedListBox1.Items.Count - 1; intIndex++)
            {
                if (checkedListBox1.GetItemChecked(intIndex) == true)
                {
                    OleDbConnection conn;                      //宣告連線的物件
                    conn = new OleDbConnection(Source);        //連線
                    conn.Open();                               //開啟資料庫
                    string str1 = label1.Text.Trim();
                    string str2 = checkedListBox1.Items[intIndex].ToString();
                    InsertCmd = "Insert Into 選課資料表(學號,課號) Values('" + str1.Substring(3, 5) + "','" + str2.Substring(0, 4) + "')";
                    OleDbCommand cmd = new OleDbCommand(InsertCmd, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();                              // 關閉資料庫
                    MessageBox.Show("加選成功！");
                }
            }
        }
    }
}