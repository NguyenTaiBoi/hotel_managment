namespace GUI
{
    partial class FormKinhDoanh
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
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.txt_MaKhachHang = new System.Windows.Forms.TextBox();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.lb_MaPhong = new System.Windows.Forms.Label();
            this.lb_NgayDatPhong = new System.Windows.Forms.Label();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_NgayDatPhong = new System.Windows.Forms.TextBox();
            this.lb_NgayTraPhong = new System.Windows.Forms.Label();
            this.txt_NgayTraPhong = new System.Windows.Forms.TextBox();
            this.lb_ThoiGian = new System.Windows.Forms.Label();
            this.txt_ThoiGian = new System.Windows.Forms.TextBox();
            this.lb_DonGia = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.lb_ThanhTien = new System.Windows.Forms.Label();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.bt_TroVe = new System.Windows.Forms.Button();
            this.bt_XuatHoaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.AutoSize = true;
            this.lb_MaKH.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaKH.Location = new System.Drawing.Point(12, 31);
            this.lb_MaKH.Name = "lb_MaKH";
            this.lb_MaKH.Size = new System.Drawing.Size(128, 23);
            this.lb_MaKH.TabIndex = 1;
            this.lb_MaKH.Text = "Mã Khách hàng";
            // 
            // txt_MaKhachHang
            // 
            this.txt_MaKhachHang.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKhachHang.Location = new System.Drawing.Point(157, 28);
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.Size = new System.Drawing.Size(227, 31);
            this.txt_MaKhachHang.TabIndex = 2;
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoTen.Location = new System.Drawing.Point(79, 174);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(61, 23);
            this.lb_HoTen.TabIndex = 1;
            this.lb_HoTen.Text = "Họ tên";
            // 
            // lb_MaPhong
            // 
            this.lb_MaPhong.AutoSize = true;
            this.lb_MaPhong.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaPhong.Location = new System.Drawing.Point(560, 31);
            this.lb_MaPhong.Name = "lb_MaPhong";
            this.lb_MaPhong.Size = new System.Drawing.Size(88, 23);
            this.lb_MaPhong.TabIndex = 1;
            this.lb_MaPhong.Text = "Mã phòng";
            // 
            // lb_NgayDatPhong
            // 
            this.lb_NgayDatPhong.AutoSize = true;
            this.lb_NgayDatPhong.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayDatPhong.Location = new System.Drawing.Point(9, 264);
            this.lb_NgayDatPhong.Name = "lb_NgayDatPhong";
            this.lb_NgayDatPhong.Size = new System.Drawing.Size(131, 23);
            this.lb_NgayDatPhong.TabIndex = 1;
            this.lb_NgayDatPhong.Text = "Ngày đặt phòng";
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TimKiem.Location = new System.Drawing.Point(670, 95);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(110, 43);
            this.bt_TimKiem.TabIndex = 3;
            this.bt_TimKiem.Text = "Tìm kiếm";
            this.bt_TimKiem.UseVisualStyleBackColor = true;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaPhong.Location = new System.Drawing.Point(654, 28);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.Size = new System.Drawing.Size(227, 31);
            this.txt_MaPhong.TabIndex = 2;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Enabled = false;
            this.txt_HoTen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(157, 171);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(227, 31);
            this.txt_HoTen.TabIndex = 2;
            // 
            // txt_NgayDatPhong
            // 
            this.txt_NgayDatPhong.Enabled = false;
            this.txt_NgayDatPhong.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayDatPhong.Location = new System.Drawing.Point(157, 261);
            this.txt_NgayDatPhong.Name = "txt_NgayDatPhong";
            this.txt_NgayDatPhong.Size = new System.Drawing.Size(227, 31);
            this.txt_NgayDatPhong.TabIndex = 2;
            // 
            // lb_NgayTraPhong
            // 
            this.lb_NgayTraPhong.AutoSize = true;
            this.lb_NgayTraPhong.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayTraPhong.Location = new System.Drawing.Point(9, 345);
            this.lb_NgayTraPhong.Name = "lb_NgayTraPhong";
            this.lb_NgayTraPhong.Size = new System.Drawing.Size(128, 23);
            this.lb_NgayTraPhong.TabIndex = 1;
            this.lb_NgayTraPhong.Text = "Ngày trả phòng";
            // 
            // txt_NgayTraPhong
            // 
            this.txt_NgayTraPhong.Enabled = false;
            this.txt_NgayTraPhong.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayTraPhong.Location = new System.Drawing.Point(157, 342);
            this.txt_NgayTraPhong.Name = "txt_NgayTraPhong";
            this.txt_NgayTraPhong.Size = new System.Drawing.Size(227, 31);
            this.txt_NgayTraPhong.TabIndex = 2;
            // 
            // lb_ThoiGian
            // 
            this.lb_ThoiGian.AutoSize = true;
            this.lb_ThoiGian.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThoiGian.Location = new System.Drawing.Point(557, 174);
            this.lb_ThoiGian.Name = "lb_ThoiGian";
            this.lb_ThoiGian.Size = new System.Drawing.Size(80, 23);
            this.lb_ThoiGian.TabIndex = 1;
            this.lb_ThoiGian.Text = "Thời gian";
            // 
            // txt_ThoiGian
            // 
            this.txt_ThoiGian.Enabled = false;
            this.txt_ThoiGian.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThoiGian.Location = new System.Drawing.Point(654, 171);
            this.txt_ThoiGian.Name = "txt_ThoiGian";
            this.txt_ThoiGian.Size = new System.Drawing.Size(227, 31);
            this.txt_ThoiGian.TabIndex = 2;
            // 
            // lb_DonGia
            // 
            this.lb_DonGia.AutoSize = true;
            this.lb_DonGia.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DonGia.Location = new System.Drawing.Point(568, 264);
            this.lb_DonGia.Name = "lb_DonGia";
            this.lb_DonGia.Size = new System.Drawing.Size(69, 23);
            this.lb_DonGia.TabIndex = 1;
            this.lb_DonGia.Text = "Đơn giá";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Enabled = false;
            this.txt_DonGia.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Location = new System.Drawing.Point(654, 261);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(227, 31);
            this.txt_DonGia.TabIndex = 2;
            // 
            // lb_ThanhTien
            // 
            this.lb_ThanhTien.AutoSize = true;
            this.lb_ThanhTien.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThanhTien.Location = new System.Drawing.Point(545, 345);
            this.lb_ThanhTien.Name = "lb_ThanhTien";
            this.lb_ThanhTien.Size = new System.Drawing.Size(92, 23);
            this.lb_ThanhTien.TabIndex = 1;
            this.lb_ThanhTien.Text = "Thành tiền";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Enabled = false;
            this.txt_ThanhTien.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhTien.Location = new System.Drawing.Point(654, 342);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(227, 31);
            this.txt_ThanhTien.TabIndex = 2;
            // 
            // bt_TroVe
            // 
            this.bt_TroVe.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TroVe.Location = new System.Drawing.Point(135, 435);
            this.bt_TroVe.Name = "bt_TroVe";
            this.bt_TroVe.Size = new System.Drawing.Size(110, 43);
            this.bt_TroVe.TabIndex = 3;
            this.bt_TroVe.Text = "Trở về";
            this.bt_TroVe.UseVisualStyleBackColor = true;
            this.bt_TroVe.Click += new System.EventHandler(this.bt_TroVe_Click);
            // 
            // bt_XuatHoaDon
            // 
            this.bt_XuatHoaDon.Enabled = false;
            this.bt_XuatHoaDon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_XuatHoaDon.Location = new System.Drawing.Point(670, 435);
            this.bt_XuatHoaDon.Name = "bt_XuatHoaDon";
            this.bt_XuatHoaDon.Size = new System.Drawing.Size(156, 43);
            this.bt_XuatHoaDon.TabIndex = 3;
            this.bt_XuatHoaDon.Text = "Xuất hóa đơn";
            this.bt_XuatHoaDon.UseVisualStyleBackColor = true;
            this.bt_XuatHoaDon.Click += new System.EventHandler(this.bt_XuatHoaDon_Click);
            // 
            // FormKinhDoanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 551);
            this.Controls.Add(this.bt_XuatHoaDon);
            this.Controls.Add(this.bt_TroVe);
            this.Controls.Add(this.bt_TimKiem);
            this.Controls.Add(this.txt_MaPhong);
            this.Controls.Add(this.txt_NgayTraPhong);
            this.Controls.Add(this.txt_ThanhTien);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.txt_ThoiGian);
            this.Controls.Add(this.txt_NgayDatPhong);
            this.Controls.Add(this.lb_ThanhTien);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.lb_DonGia);
            this.Controls.Add(this.txt_MaKhachHang);
            this.Controls.Add(this.lb_ThoiGian);
            this.Controls.Add(this.lb_NgayTraPhong);
            this.Controls.Add(this.lb_NgayDatPhong);
            this.Controls.Add(this.lb_MaPhong);
            this.Controls.Add(this.lb_HoTen);
            this.Controls.Add(this.lb_MaKH);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKinhDoanh";
            this.Text = "FormHoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_MaKH;
        private System.Windows.Forms.TextBox txt_MaKhachHang;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.Label lb_MaPhong;
        private System.Windows.Forms.Label lb_NgayDatPhong;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.TextBox txt_MaPhong;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_NgayDatPhong;
        private System.Windows.Forms.Label lb_NgayTraPhong;
        private System.Windows.Forms.TextBox txt_NgayTraPhong;
        private System.Windows.Forms.Label lb_ThoiGian;
        private System.Windows.Forms.TextBox txt_ThoiGian;
        private System.Windows.Forms.Label lb_DonGia;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label lb_ThanhTien;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Button bt_TroVe;
        private System.Windows.Forms.Button bt_XuatHoaDon;
    }
}