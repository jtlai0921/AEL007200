namespace ch20_3
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.設定科系代碼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.課程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.學生管理與選課作業ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查詢選課記錄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定科系代碼ToolStripMenuItem,
            this.課程管理ToolStripMenuItem,
            this.學生管理與選課作業ToolStripMenuItem,
            this.查詢選課記錄ToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(726, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // 設定科系代碼ToolStripMenuItem
            // 
            this.設定科系代碼ToolStripMenuItem.Name = "設定科系代碼ToolStripMenuItem";
            this.設定科系代碼ToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.設定科系代碼ToolStripMenuItem.Text = "設定科系代碼";
            this.設定科系代碼ToolStripMenuItem.Click += new System.EventHandler(this.設定科系代碼ToolStripMenuItem_Click);
            // 
            // 課程管理ToolStripMenuItem
            // 
            this.課程管理ToolStripMenuItem.Name = "課程管理ToolStripMenuItem";
            this.課程管理ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.課程管理ToolStripMenuItem.Text = "課程管理";
            this.課程管理ToolStripMenuItem.Click += new System.EventHandler(this.課程管理ToolStripMenuItem_Click);
            // 
            // 學生管理與選課作業ToolStripMenuItem
            // 
            this.學生管理與選課作業ToolStripMenuItem.Name = "學生管理與選課作業ToolStripMenuItem";
            this.學生管理與選課作業ToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.學生管理與選課作業ToolStripMenuItem.Text = "學生管理與選課作業";
            this.學生管理與選課作業ToolStripMenuItem.Click += new System.EventHandler(this.學生管理與選課作業ToolStripMenuItem_Click);
            // 
            // 查詢選課記錄ToolStripMenuItem
            // 
            this.查詢選課記錄ToolStripMenuItem.Name = "查詢選課記錄ToolStripMenuItem";
            this.查詢選課記錄ToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.查詢選課記錄ToolStripMenuItem.Text = "查詢選課記錄";
            this.查詢選課記錄ToolStripMenuItem.Click += new System.EventHandler(this.查詢選課記錄ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 424);
            this.Controls.Add(this.MenuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "學生選課系統";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem 設定科系代碼ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 課程管理ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 學生管理與選課作業ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 查詢選課記錄ToolStripMenuItem;
    }
}

