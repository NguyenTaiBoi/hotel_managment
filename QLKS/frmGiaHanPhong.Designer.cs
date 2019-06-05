namespace QLKS
{
    partial class frmGiaHanPhong
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
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lbNgayTraPhong = new System.Windows.Forms.Label();
            this.lbNgayTraPhongMoi = new System.Windows.Forms.Label();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btTroLai = new System.Windows.Forms.Button();
            this.dtpNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTraPhongMoi = new System.Windows.Forms.DateTimePicker();
            this.btXacThuc = new System.Windows.Forms.Button();
            this.btTaoMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(94, 87);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(57, 18);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ tên:";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.Location = new System.Drawing.Point(27, 183);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(124, 18);
            this.lbCMND.TabIndex = 0;
            this.lbCMND.Text = "Chứng minh thư:";
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhong.Location = new System.Drawing.Point(70, 293);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(81, 18);
            this.lbMaPhong.TabIndex = 0;
            this.lbMaPhong.Text = "Mã phòng:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(168, 85);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(197, 26);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(168, 175);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(197, 26);
            this.txtCMND.TabIndex = 1;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(168, 285);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(197, 26);
            this.txtMaPhong.TabIndex = 1;
            this.txtMaPhong.TextChanged += new System.EventHandler(this.txtMaPhong_TextChanged);
            // 
            // lbNgayTraPhong
            // 
            this.lbNgayTraPhong.AutoSize = true;
            this.lbNgayTraPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTraPhong.Location = new System.Drawing.Point(458, 87);
            this.lbNgayTraPhong.Name = "lbNgayTraPhong";
            this.lbNgayTraPhong.Size = new System.Drawing.Size(117, 18);
            this.lbNgayTraPhong.TabIndex = 0;
            this.lbNgayTraPhong.Text = "Ngày trả phòng:";
            // 
            // lbNgayTraPhongMoi
            // 
            this.lbNgayTraPhongMoi.AutoSize = true;
            this.lbNgayTraPhongMoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTraPhongMoi.Location = new System.Drawing.Point(426, 183);
            this.lbNgayTraPhongMoi.Name = "lbNgayTraPhongMoi";
            this.lbNgayTraPhongMoi.Size = new System.Drawing.Size(149, 18);
            this.lbNgayTraPhongMoi.TabIndex = 0;
            this.lbNgayTraPhongMoi.Text = "Ngày trả phòng mới:";
            // 
            // btXacNhan
            // 
            this.btXacNhan.Enabled = false;
            this.btXacNhan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXacNhan.Location = new System.Drawing.Point(429, 276);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(114, 35);
            this.btXacNhan.TabIndex = 2;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // btHuy
            // 
            this.btHuy.Enabled = false;
            this.btHuy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Location = new System.Drawing.Point(599, 276);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(114, 35);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btTroLai
            // 
            this.btTroLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTroLai.Location = new System.Drawing.Point(747, 276);
            this.btTroLai.Name = "btTroLai";
            this.btTroLai.Size = new System.Drawing.Size(114, 35);
            this.btTroLai.TabIndex = 2;
            this.btTroLai.Text = "Trở lại";
            this.btTroLai.UseVisualStyleBackColor = true;
            this.btTroLai.Click += new System.EventHandler(this.btTroLai_Click);
            // 
            // dtpNgayTraPhong
            // 
            this.dtpNgayTraPhong.Enabled = false;
            this.dtpNgayTraPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTraPhong.Location = new System.Drawing.Point(581, 86);
            this.dtpNgayTraPhong.Name = "dtpNgayTraPhong";
            this.dtpNgayTraPhong.Size = new System.Drawing.Size(280, 26);
            this.dtpNgayTraPhong.TabIndex = 3;
            // 
            // dtpNgayTraPhongMoi
            // 
            this.dtpNgayTraPhongMoi.Enabled = false;
            this.dtpNgayTraPhongMoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTraPhongMoi.Location = new System.Drawing.Point(581, 177);
            this.dtpNgayTraPhongMoi.Name = "dtpNgayTraPhongMoi";
            this.dtpNgayTraPhongMoi.Size = new System.Drawing.Size(280, 26);
            this.dtpNgayTraPhongMoi.TabIndex = 3;
            // 
            // btXacThuc
            // 
            this.btXacThuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXacThuc.Location = new System.Drawing.Point(168, 356);
            this.btXacThuc.Name = "btXacThuc";
            this.btXacThuc.Size = new System.Drawing.Size(114, 35);
            this.btXacThuc.TabIndex = 2;
            this.btXacThuc.Text = "Xác thực";
            this.btXacThuc.UseVisualStyleBackColor = true;
            this.btXacThuc.Click += new System.EventHandler(this.btXacThuc_Click);
            // 
            // btTaoMoi
            // 
            this.btTaoMoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoMoi.Location = new System.Drawing.Point(429, 276);
            this.btTaoMoi.Name = "btTaoMoi";
            this.btTaoMoi.Size = new System.Drawing.Size(114, 35);
            this.btTaoMoi.TabIndex = 2;
            this.btTaoMoi.Text = "Tạo mới";
            this.btTaoMoi.UseVisualStyleBackColor = true;
            this.btTaoMoi.Visible = false;
            this.btTaoMoi.Click += new System.EventHandler(this.btTaoMoi_Click);
            // 
            // frmGiaHanPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 447);
            this.Controls.Add(this.dtpNgayTraPhongMoi);
            this.Controls.Add(this.dtpNgayTraPhong);
            this.Controls.Add(this.btTroLai);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btXacThuc);
            this.Controls.Add(this.btTaoMoi);
            this.Controls.Add(this.btXacNhan);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lbMaPhong);
            this.Controls.Add(this.lbCMND);
            this.Controls.Add(this.lbNgayTraPhongMoi);
            this.Controls.Add(this.lbNgayTraPhong);
            this.Controls.Add(this.lbHoTen);
            this.Name = "frmGiaHanPhong";
            this.Text = "Gia hạn phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lbNgayTraPhong;
        private System.Windows.Forms.Label lbNgayTraPhongMoi;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btTroLai;
        private System.Windows.Forms.DateTimePicker dtpNgayTraPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayTraPhongMoi;
        private System.Windows.Forms.Button btXacThuc;
        private System.Windows.Forms.Button btTaoMoi;
    }
}