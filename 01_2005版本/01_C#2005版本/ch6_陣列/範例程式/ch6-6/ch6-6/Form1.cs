using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;   //引用System.Collections
namespace ch6_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      private void button1_Click(object sender, EventArgs e)
      {//宣告及初值設定
        ArrayList Score=new ArrayList();
        int i, Sum=0;
        int[] A =new int[] {60,65,70,80,90};
        string Temp= "座號　　成績" + "\n";
        Temp += "============" + "\n";
        // 輸入5位同學成績到陣列串列中
        for(i = 0;i<=4;i++)
        {
            Score.Add(A[i]);  //將A陣列的資料加入到Score陣列類別中
        }
        // 處理
        for (i = 0; i <= Score.Count - 1; i++)
        {
            Temp += (i + 1) + "　　　" + Score[i] + "\n";
            Sum = Sum + (int)(Score[i]);
        }
        // 輸出
        label3.Text  = Temp;
        label4.Text = System.Convert.ToString(Sum);
        label5.Text = System.Convert.ToString(Sum / Score.Count);
        }
    }
}