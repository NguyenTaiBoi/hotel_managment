namespace GUI
{
    partial class FormDatPhong
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
            this.btHuy = new System.Windows.Forms.Button();
            this.btDanhSachPhong = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btTroVe = new System.Windows.Forms.Button();
            this.dtpNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDatPhong = new System.Windows.Forms.DateTimePicker();
            this.txtQuocTich = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbQuocTich = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbTuoi = new System.Windows.Forms.Label();
            this.lbNgayTraPhong = new System.Windows.Forms.Label();
            this.lbNgayDatPhong = new System.Windows.Forms.Label();
            this.lbPhongDaChon = new System.Windows.Forms.Label();
            this.lbPhong = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btHuy
            // 
            this.btHuy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Location = new System.Drawing.Point(861, 568);
            this.btHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(133, 49);
            this.btHuy.TabIndex = 25;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btDanhSachPhong
            // 
            this.btDanhSachPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDanhSachPhong.Location = new System.Drawing.Point(834, 82);
            this.btDanhSachPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btDanhSachPhong.Name = "btDanhSachPhong";
            this.btDanhSachPhong.Size = new System.Drawing.Size(253, 49);
            this.btDanhSachPhong.TabIndex = 24;
            this.btDanhSachPhong.Text = "Danh sách phòng";
            this.btDanhSachPhong.UseVisualStyleBackColor = true;
            this.btDanhSachPhong.Click += new System.EventHandler(this.btDanhSachPhong_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(670, 568);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(133, 49);
            this.btThem.TabIndex = 23;
            this.btThem.Text = "Tạo mới";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Visible = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(669, 568);
            this.btLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(133, 49);
            this.btLuu.TabIndex = 22;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btTroVe
            // 
            this.btTroVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTroVe.Location = new System.Drawing.Point(1033, 568);
            this.btTroVe.Margin = new System.Windows.Forms.Padding(4);
            this.btTroVe.Name = "btTroVe";
            this.btTroVe.Size = new System.Drawing.Size(133, 49);
            this.btTroVe.TabIndex = 21;
            this.btTroVe.Text = "Trở về";
            this.btTroVe.UseVisualStyleBackColor = true;
            this.btTroVe.Click += new System.EventHandler(this.btTroVe_Click);
            // 
            // dtpNgayTraPhong
            // 
            this.dtpNgayTraPhong.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTraPhong.Location = new System.Drawing.Point(834, 435);
            this.dtpNgayTraPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTraPhong.MinDate = new System.DateTime(2019, 6, 5, 12, 33, 31, 0);
            this.dtpNgayTraPhong.Name = "dtpNgayTraPhong";
            this.dtpNgayTraPhong.Size = new System.Drawing.Size(360, 32);
            this.dtpNgayTraPhong.TabIndex = 20;
            this.dtpNgayTraPhong.Value = new System.DateTime(2019, 6, 5, 12, 33, 31, 0);
            // 
            // dtpNgayDatPhong
            // 
            this.dtpNgayDatPhong.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDatPhong.Location = new System.Drawing.Point(834, 311);
            this.dtpNgayDatPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayDatPhong.Name = "dtpNgayDatPhong";
            this.dtpNgayDatPhong.Size = new System.Drawing.Size(360, 32);
            this.dtpNgayDatPhong.TabIndex = 19;
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuocTich.Location = new System.Drawing.Point(196, 581);
            this.txtQuocTich.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.Size = new System.Drawing.Size(319, 30);
            this.txtQuocTich.TabIndex = 17;
            this.txtQuocTich.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuocTich_KeyPress);
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(196, 440);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(319, 30);
            this.txtCMND.TabIndex = 16;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(196, 311);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(319, 30);
            this.txtSDT.TabIndex = 18;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtPhong
            // 
            this.txtPhong.Enabled = false;
            this.txtPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhong.Location = new System.Drawing.Point(834, 187);
            this.txtPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(360, 30);
            this.txtPhong.TabIndex = 15;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuoi.Location = new System.Drawing.Point(196, 187);
            this.txtTuoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(319, 30);
            this.txtTuoi.TabIndex = 14;
            this.txtTuoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTuoi_KeyPress);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(196, 89);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(319, 30);
            this.txtHoTen.TabIndex = 13;
            this.txtHoTen.TextChanged += new System.EventHandler(this.TxtHoTen_TextChanged);
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // lbQuocTich
            // 
            this.lbQuocTich.AutoSize = true;
            this.lbQuocTich.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuocTich.Location = new System.Drawing.Point(80, 584);
            this.lbQuocTich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuocTich.Name = "lbQuocTich";
            this.lbQuocTich.Size = new System.Drawing.Size(99, 23);
            this.lbQuocTich.TabIndex = 11;
            this.lbQuocTich.Text = "Quốc tịch:";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.Location = new System.Drawing.Point(17, 443);
            this.lbCMND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(155, 23);
            this.lbCMND.TabIndex = 10;
            this.lbCMND.Text = "Chứng minh thư:";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(44, 313);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(130, 23);
            this.lbSDT.TabIndex = 9;
            this.lbSDT.Text = "Số điện thoại:";
            // 
            // lbTuoi
            // 
            this.lbTuoi.AutoSize = true;
            this.lbTuoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuoi.Location = new System.Drawing.Point(127, 190);
            this.lbTuoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTuoi.Name = "lbTuoi";
            this.lbTuoi.Size = new System.Drawing.Size(52, 23);
            this.lbTuoi.TabIndex = 8;
            this.lbTuoi.Text = "Tuổi:";
            // 
            // lbNgayTraPhong
            // 
            this.lbNgayTraPhong.AutoSize = true;
            this.lbNgayTraPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTraPhong.Location = new System.Drawing.Point(662, 441);
            this.lbNgayTraPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayTraPhong.Name = "lbNgayTraPhong";
            this.lbNgayTraPhong.Size = new System.Drawing.Size(150, 23);
            this.lbNgayTraPhong.TabIndex = 7;
            this.lbNgayTraPhong.Text = "Ngày trả phòng:";
            // 
            // lbNgayDatPhong
            // 
            this.lbNgayDatPhong.AutoSize = true;
            this.lbNgayDatPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayDatPhong.Location = new System.Drawing.Point(658, 313);
            this.lbNgayDatPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayDatPhong.Name = "lbNgayDatPhong";
            this.lbNgayDatPhong.Size = new System.Drawing.Size(154, 23);
            this.lbNgayDatPhong.TabIndex = 6;
            this.lbNgayDatPhong.Text = "Ngày đặt phòng:";
            // 
            // lbPhongDaChon
            // 
            this.lbPhongDaChon.AutoSize = true;
            this.lbPhongDaChon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhongDaChon.Location = new System.Drawing.Point(666, 190);
            this.lbPhongDaChon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhongDaChon.Name = "lbPhongDaChon";
            this.lbPhongDaChon.Size = new System.Drawing.Size(146, 23);
            this.lbPhongDaChon.TabIndex = 5;
            this.lbPhongDaChon.Text = "Phòng đã chọn:";
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhong.Location = new System.Drawing.Point(745, 96);
            this.lbPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(71, 23);
            this.lbPhong.TabIndex = 12;
            this.lbPhong.Text = "Phòng:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(100, 92);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(79, 23);
            this.lbHoTen.TabIndex = 4;
            this.lbHoTen.Text = "Họ Tên:";
            // 
            // FormDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 698);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btDanhSachPhong);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btTroVe);
            this.Controls.Add(this.dtpNgayTraPhong);
            this.Controls.Add(this.dtpNgayDatPhong);
            this.Controls.Add(this.txtQuocTich);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lbQuocTich);
            this.Controls.Add(this.lbCMND);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbTuoi);
            this.Controls.Add(this.lbNgayTraPhong);
            this.Controls.Add(this.lbNgayDatPhong);
            this.Controls.Add(this.lbPhongDaChon);
            this.Controls.Add(this.lbPhong);
            this.Controls.Add(this.lbHoTen);
            this.IsMdiContainer = true;
            this.Name = "FormDatPhong";
            this.Text = "FormDatPhong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //public string ValueChonPhong = "";

        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btDanhSachPhong;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btTroVe;
        private System.Windows.Forms.DateTimePicker dtpNgayTraPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayDatPhong;
        private System.Windows.Forms.TextBox txtQuocTich;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbQuocTich;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbTuoi;
        private System.Windows.Forms.Label lbNgayTraPhong;
        private System.Windows.Forms.Label lbNgayDatPhong;
        private System.Windows.Forms.Label lbPhongDaChon;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.Label lbHoTen;
    }
}