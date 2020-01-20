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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        void Show_Record()
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "select 學號,姓名,系名 from 學生資料表,科系代碼資料表 where 學生資料表.系碼=科系代碼資料表.系碼";
            //宣告物件
            OleDbDataAdapter DtApter;
            DataSet DtSet;
            DtApter = new OleDbDataAdapter(SelectCmd, conn);
            DtSet = new DataSet();
            //讀取資料表
            DtApter.Fill(DtSet, "Student");
            dataGridView1.DataSource = DtSet.Tables["Student"];
            conn.Close();                       // 關閉資料庫
            label5.Visible = false;
            label6.Visible = false;
            textBox3.Visible = false;
            button7.Visible = false;
        }
        void Show_Dept_No()
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "select * from 科系代碼資料表";
            OleDbCommand cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();
            //顯示資料表欄位的所有資料
            while (reader.Read())
                comboBox1.Items.Add(reader["系碼"] + "/" + reader["系名"]);
            conn.Close();                       // 關閉資料庫
        }

        void Display_Dept_No_Name()
        {
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd = "select 科系代碼資料表.系碼,系名 from 科系代碼資料表,學生資料表 where 科系代碼資料表.系碼=學生資料表.系碼 And 學號='" + textBox3.Text.Trim() + "'";
            OleDbCommand cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();
            //顯示資料表欄位的所有資料
            if(reader.Read())
                comboBox1.Text=reader["系碼"] + "/" + reader["系名"];
            conn.Close();                       // 關閉資料庫
        }


        private void button1_Click(object sender, EventArgs e)
        {//查詢
            label5.Visible = true;
            label6.Visible = true;
            textBox3.Visible = true;
            button7.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {//新增
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string InsertCmd;
            string str1 = comboBox1.Text.Trim();
            InsertCmd = "Insert Into 學生資料表(學號,姓名,系碼) Values('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + str1.Substring(0, 4) + "')";
            OleDbCommand cmd = new OleDbCommand(InsertCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();                              // 關閉資料庫
            MessageBox.Show("新增成功！");
            Show_Record();

        }

        private void button3_Click(object sender, EventArgs e)
        { //修改
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string UpdateCmd;
            string str1 = comboBox1.Text.Trim();
            UpdateCmd = "UPDATE 學生資料表 SET 學號='" + textBox1.Text.Trim() + "',姓名='" + textBox2.Text.Trim() + "' ,系碼='" + str1.Substring(0, 4) + "' WHERE 學號='" + textBox1.Text.Trim() + "'";
            OleDbCommand cmd = new OleDbCommand(UpdateCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("修改成功！");
            Show_Record();

        }

        private void button4_Click(object sender, EventArgs e)
        {//刪除
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string DeleteCmd;
            DeleteCmd = "Delete From 學生資料表 WHERE 學號='" + textBox1.Text.Trim() + "'";
            OleDbCommand cmd = new OleDbCommand(DeleteCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("刪除成功！");
            textBox1.Clear();
            textBox2.Clear();
            Show_Record();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Show_Record();
            Show_Dept_No();
        }

        private void button7_Click(object sender, EventArgs e)
        {//查詢(Go)
            string dbpath = "DBMS.mdb";                //宣告資料庫所在的路徑變數
            string Source;                             //宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath;
            OleDbConnection conn;                      //宣告連線的物件
            conn = new OleDbConnection(Source);        //連線
            conn.Open();                               //開啟資料庫
            string SelectCmd;
            SelectCmd = "Select * From 學生資料表 Where 學號='" + textBox3.Text.Trim() + "'";
            OleDbCommand Cmd = new OleDbCommand(SelectCmd, conn);
            OleDbDataReader reader;
            reader = Cmd.ExecuteReader();
            //顯示資料表欄位的所有資料
            while (reader.Read())
            {
                textBox1.Text = reader["學號"].ToString();
                textBox2.Text = reader["姓名"].ToString();
            }
            Display_Dept_No_Name();
            conn.Close();                       // 關閉資料庫
        }

        private void button5_Click(object sender, EventArgs e)
        {
          if (textBox1.Text == "")
            MessageBox.Show("您尚未輸入學號！");
          else
          {
            Form4 ShowForm = new Form4();   //建立Form4實體
            ShowForm.Show();                //顯示MDI的子表單
            ShowForm.label1.Text = "學號：" + this.textBox1.Text + "  姓名：" + this.textBox2.Text;
          }
        }
    }
}