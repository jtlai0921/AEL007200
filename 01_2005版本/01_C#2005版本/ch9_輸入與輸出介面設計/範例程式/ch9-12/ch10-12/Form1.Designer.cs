namespace ch10_12
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.ListBox2 = new System.Windows.Forms.ListBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(133, 90);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(63, 23);
            this.Button2.TabIndex = 31;
            this.Button2.Text = "退選";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(133, 25);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(63, 23);
            this.Button1.TabIndex = 29;
            this.Button1.Text = "加選";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ListBox2
            // 
            this.ListBox2.FormattingEnabled = true;
            this.ListBox2.ItemHeight = 12;
            this.ListBox2.Location = new System.Drawing.Point(202, 25);
            this.ListBox2.Name = "ListBox2";
            this.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox2.Size = new System.Drawing.Size(120, 124);
            this.ListBox2.TabIndex = 28;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(200, 10);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 12);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "你選的課程";
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 12;
            this.ListBox1.Items.AddRange(new object[] {
            "國文",
            "英文",
            "數學",
            "程式設計",
            "資料庫系統"});
            this.ListBox1.Location = new System.Drawing.Point(7, 25);
            this.ListBox1.MultiColumn = true;
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox1.Size = new System.Drawing.Size(120, 124);
            this.ListBox1.TabIndex = 26;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(5, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 12);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "全部課程";
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(202, 155);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(120, 23);
            this.Button5.TabIndex = 33;
            this.Button5.Text = "排序";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 189);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ListBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.ListBox ListBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button5;

    }
}

