namespace QLTCDemo
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngỨngDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMónNănToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiKiểuNấuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiMónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýMónNănToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đóngỨngDụngToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đóngỨngDụngToolStripMenuItem
            // 
            this.đóngỨngDụngToolStripMenuItem.Name = "đóngỨngDụngToolStripMenuItem";
            this.đóngỨngDụngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đóngỨngDụngToolStripMenuItem.Text = "Đóng ứng dụng";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // quảnLýMónNănToolStripMenuItem
            // 
            this.quảnLýMónNănToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMớiKiểuNấuToolStripMenuItem,
            this.thêmMớiMónĂnToolStripMenuItem});
            this.quảnLýMónNănToolStripMenuItem.Name = "quảnLýMónNănToolStripMenuItem";
            this.quảnLýMónNănToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.quảnLýMónNănToolStripMenuItem.Text = "Quản lý món ăn";
            // 
            // thêmMớiKiểuNấuToolStripMenuItem
            // 
            this.thêmMớiKiểuNấuToolStripMenuItem.Name = "thêmMớiKiểuNấuToolStripMenuItem";
            this.thêmMớiKiểuNấuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thêmMớiKiểuNấuToolStripMenuItem.Text = "Thêm mới kiểu nấu";
            this.thêmMớiKiểuNấuToolStripMenuItem.Click += new System.EventHandler(this.thêmMớiKiểuNấuToolStripMenuItem_Click);
            // 
            // thêmMớiMónĂnToolStripMenuItem
            // 
            this.thêmMớiMónĂnToolStripMenuItem.Name = "thêmMớiMónĂnToolStripMenuItem";
            this.thêmMớiMónĂnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thêmMớiMónĂnToolStripMenuItem.Text = "Thêm mới món ăn";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản lý tiệc cưới 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngỨngDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMónNănToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiKiểuNấuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiMónĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
    }
}

