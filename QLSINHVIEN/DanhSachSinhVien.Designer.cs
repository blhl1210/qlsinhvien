namespace QLSINHVIEN
{
    partial class DanhSachSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_MaSV = new System.Windows.Forms.TextBox();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_Lop = new System.Windows.Forms.ComboBox();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.pb_AnhDaiDien = new System.Windows.Forms.PictureBox();
            this.btn_Duyet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Sinh: ";
            // 
            // tb_MaSV
            // 
            this.tb_MaSV.Location = new System.Drawing.Point(203, 40);
            this.tb_MaSV.Name = "tb_MaSV";
            this.tb_MaSV.Size = new System.Drawing.Size(158, 20);
            this.tb_MaSV.TabIndex = 5;
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Location = new System.Drawing.Point(203, 77);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(158, 20);
            this.tb_HoTen.TabIndex = 6;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(203, 152);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(100, 20);
            this.tb_DiaChi.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 219);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cb_Lop
            // 
            this.cb_Lop.FormattingEnabled = true;
            this.cb_Lop.Location = new System.Drawing.Point(203, 115);
            this.cb_Lop.Name = "cb_Lop";
            this.cb_Lop.Size = new System.Drawing.Size(128, 21);
            this.cb_Lop.TabIndex = 11;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Location = new System.Drawing.Point(203, 185);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtp_NgaySinh.TabIndex = 12;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(30, 227);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(176, 227);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 14;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(319, 227);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(455, 227);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(75, 23);
            this.btn_Dong.TabIndex = 16;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // pb_AnhDaiDien
            // 
            this.pb_AnhDaiDien.Location = new System.Drawing.Point(564, 40);
            this.pb_AnhDaiDien.Name = "pb_AnhDaiDien";
            this.pb_AnhDaiDien.Size = new System.Drawing.Size(138, 128);
            this.pb_AnhDaiDien.TabIndex = 17;
            this.pb_AnhDaiDien.TabStop = false;
            // 
            // btn_Duyet
            // 
            this.btn_Duyet.Location = new System.Drawing.Point(608, 181);
            this.btn_Duyet.Name = "btn_Duyet";
            this.btn_Duyet.Size = new System.Drawing.Size(52, 23);
            this.btn_Duyet.TabIndex = 18;
            this.btn_Duyet.Text = "Duyệt";
            this.btn_Duyet.UseVisualStyleBackColor = true;
            this.btn_Duyet.Click += new System.EventHandler(this.btn_Duyet_Click);
            // 
            // DanhSachSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 501);
            this.Controls.Add(this.btn_Duyet);
            this.Controls.Add(this.pb_AnhDaiDien);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.cb_Lop);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_HoTen);
            this.Controls.Add(this.tb_MaSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DanhSachSinhVien";
            this.Text = "DanhSachSinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhDaiDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_MaSV;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_Lop;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.PictureBox pb_AnhDaiDien;
        private System.Windows.Forms.Button btn_Duyet;
    }
}