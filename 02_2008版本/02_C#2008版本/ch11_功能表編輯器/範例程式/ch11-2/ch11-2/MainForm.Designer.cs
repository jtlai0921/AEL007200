namespace ch11_2
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.表單總管ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.第一個表單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.第二個表單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.表單總管ToolStripMenuItem,
            this.結束ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 表單總管ToolStripMenuItem
            // 
            this.表單總管ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.第一個表單ToolStripMenuItem,
            this.第二個表單ToolStripMenuItem});
            this.表單總管ToolStripMenuItem.Name = "表單總管ToolStripMenuItem";
            this.表單總管ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.表單總管ToolStripMenuItem.Text = "表單總管";
            // 
            // 第一個表單ToolStripMenuItem
            // 
            this.第一個表單ToolStripMenuItem.Name = "第一個表單ToolStripMenuItem";
            this.第一個表單ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.第一個表單ToolStripMenuItem.Text = "第一個表單";
            this.第一個表單ToolStripMenuItem.Click += new System.EventHandler(this.第一個表單ToolStripMenuItem_Click);
            // 
            // 第二個表單ToolStripMenuItem
            // 
            this.第二個表單ToolStripMenuItem.Name = "第二個表單ToolStripMenuItem";
            this.第二個表單ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.第二個表單ToolStripMenuItem.Text = "第二個表單";
            this.第二個表單ToolStripMenuItem.Click += new System.EventHandler(this.第二個表單ToolStripMenuItem_Click);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.結束ToolStripMenuItem.Text = "結束";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 表單總管ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 第一個表單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 第二個表單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
    }
}

