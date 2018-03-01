namespace QLSINHVIEN
{
    partial class Form1
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
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinChínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem,
            this.sinhViênToolStripMenuItem,
            this.khoaToolStripMenuItem,
            this.thôngTinChínhToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hToolStripMenuItem.Text = "Hệ thống";
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchSinhViênToolStripMenuItem});
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.sinhViênToolStripMenuItem.Text = "Sinh viên";
            // 
            // danhSáchSinhViênToolStripMenuItem
            // 
            this.danhSáchSinhViênToolStripMenuItem.Name = "danhSáchSinhViênToolStripMenuItem";
            this.danhSáchSinhViênToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.danhSáchSinhViênToolStripMenuItem.Text = "Danh sách sinh viên";
            this.danhSáchSinhViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchSinhViênToolStripMenuItem_Click);
            // 
            // khoaToolStripMenuItem
            // 
            this.khoaToolStripMenuItem.Name = "khoaToolStripMenuItem";
            this.khoaToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.khoaToolStripMenuItem.Text = "Khoa";
            // 
            // thôngTinChínhToolStripMenuItem
            // 
            this.thôngTinChínhToolStripMenuItem.Name = "thôngTinChínhToolStripMenuItem";
            this.thôngTinChínhToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.thôngTinChínhToolStripMenuItem.Text = "Thông tin chính";
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinChínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
    }
}

