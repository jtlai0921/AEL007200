using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ch10_9A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        //三種樣式都有勾選
        if(checkBox1.Checked==true) 
        {
           if(checkBox2.Checked==true) 
           {
               if(checkBox3.Checked==true) 
                    label1.Font = new Font("新細明體", 20, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
               else
                    label1.Font = new Font("新細明體", 20, FontStyle.Italic | FontStyle.Underline);
           }
            else  //勾選粗體，沒有勾選斜體
           {

               if(checkBox3.Checked==true) 
                    label1.Font = new Font("新細明體", 20, FontStyle.Bold | FontStyle.Underline);
                else
                    label1.Font = new Font("新細明體", 20, FontStyle.Bold);
           }
        }
        else //沒有勾選粗體
        {
           if(checkBox2.Checked==true) 
           {
               if(checkBox3.Checked==true) 
                    label1.Font = new Font("新細明體", 20, FontStyle.Italic | FontStyle.Underline);
               else
                    label1.Font = new Font("新細明體", 20, FontStyle.Italic);
           }
            else
           {
               if(checkBox3.Checked==true) 
                    label1.Font = new Font("新細明體", 20, FontStyle.Underline);
                else
                    label1.Font = new Font("新細明體", 20, FontStyle.Regular);
           }
          }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //三種樣式都有勾選
            if (checkBox1.Checked == true)
            {
                if (checkBox2.Checked == true)
                {
                    if (checkBox3.Checked == true)
                        label1.Font = new Font("新細明體", 20, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    else
                        label1.Font = new Font("新細明體", 20, FontStyle.Italic | FontStyle.Underline);
                }
                else  //勾選粗體，沒有勾選斜體
                {

                    if (checkBox3.Checked == true)
                        label1.Font = new Font("新細明體", 20, FontStyle.Bold | FontStyle.Underline);
                    else
                        label1.Font = new Font("新細明體", 20, FontStyle.Bold);
                }
            }
            else //沒有勾選粗體
            {
                if (checkBox2.Checked == true)
                {
                    if (checkBox3.Checked == true)
                        label1.Font = new Font("新細明體", 20, FontStyle.Italic | FontStyle.Underline);
                    else
                        label1.Font = new Font("新細明體", 20, FontStyle.Italic);
                }
                else
                {
                    if (checkBox3.Checked == true)
                        label1.Font = new Font("新細明體", 20, FontStyle.Underline);
                    else
                        label1.Font = new Font("新細明體", 20, FontStyle.Regular);
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //三種樣式都有勾選
            if (checkBox1.Checked == true)
            {
                if (checkBox2.Checked == true)
                {
                    if (checkBox3.Checked == true)
                        label1.Font = new Font("新細明體", 20, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    else
                        label1.Font = new Font("新細明體", 20, FontStyle.Italic | FontStyle.Underline);
                }
                else  //勾選粗體，沒有勾選斜體
                {

                    if (checkBox3.Checked == true)
                        label1.Font = new Font("新細明體", 20, FontStyle.Bold | FontStyle.Underline);
                    else
                        label1.Font = new Font("新細明體", 20, FontStyle.Bold);
                }
            }
            else //沒有勾選粗體
            {
                if (checkBox2.Checked == true)
                {
                    if (checkBox3.Checked == true)
                        label1.Font = new Font("新細明體", 20, FontStyle.Italic | FontStyle.Underline);
                    else
                        label1.Font = new Font("新細明體", 20, FontStyle.Italic);
                }
                else
                {
                    if (checkBox3.Checked == true)
                        label1.Font = new Font("新細明體", 20, FontStyle.Underline);
                    else
                        label1.Font = new Font("新細明體", 20, FontStyle.Regular);
                }
            }
        }
       }
    }
