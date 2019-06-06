namespace GUI
{
    partial class FormGiaHanPhong
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
            this.dtpNgayTraPhongMoi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.btTroLai = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btXacThuc = new System.Windows.Forms.Button();
            this.btTaoMoi = new System.Windows.Forms.Button();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbNgayTraPhongMoi = new System.Windows.Forms.Label();
            this.lbNgayTraPhong = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpNgayTraPhongMoi
            // 
            this.dtpNgayTraPhongMoi.Enabled = false;
            this.dtpNgayTraPhongMoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTraPhongMoi.Location = new System.Drawing.Point(771, 200);
            this.dtpNgayTraPhongMoi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTraPhongMoi.Name = "dtpNgayTraPhongMoi";
            this.dtpNgayTraPhongMoi.Size = new System.Drawing.Size(372, 30);
            this.dtpNgayTraPhongMoi.TabIndex = 17;
            // 
            // dtpNgayTraPhong
            // 
            this.dtpNgayTraPhong.Enabled = false;
            this.dtpNgayTraPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTraPhong.Location = new System.Drawing.Point(771, 88);
            this.dtpNgayTraPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTraPhong.Name = "dtpNgayTraPhong";
            this.dtpNgayTraPhong.Size = new System.Drawing.Size(372, 30);
            this.dtpNgayTraPhong.TabIndex = 18;
            // 
            // btTroLai
            // 
            this.btTroLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTroLai.Location = new System.Drawing.Point(992, 322);
            this.btTroLai.Margin = new System.Windows.Forms.Padding(4);
            this.btTroLai.Name = "btTroLai";
            this.btTroLai.Size = new System.Drawing.Size(152, 43);
            this.btTroLai.TabIndex = 12;
            this.btTroLai.Text = "Trở lại";
            this.btTroLai.UseVisualStyleBackColor = true;
            // 
            // btHuy
            // 
            this.btHuy.Enabled = false;
            this.btHuy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Location = new System.Drawing.Point(795, 322);
            this.btHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(152, 43);
            this.btHuy.TabIndex = 13;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            // 
            // btXacThuc
            // 
            this.btXacThuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXacThuc.Location = new System.Drawing.Point(220, 420);
            this.btXacThuc.Margin = new System.Windows.Forms.Padding(4);
            this.btXacThuc.Name = "btXacThuc";
            this.btXacThuc.Size = new System.Drawing.Size(152, 43);
            this.btXacThuc.TabIndex = 14;
            this.btXacThuc.Text = "Xác thực";
            this.btXacThuc.UseVisualStyleBackColor = true;
            // 
            // btTaoMoi
            // 
            this.btTaoMoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoMoi.Location = new System.Drawing.Point(568, 322);
            this.btTaoMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btTaoMoi.Name = "btTaoMoi";
            this.btTaoMoi.Size = new System.Drawing.Size(152, 43);
            this.btTaoMoi.TabIndex = 15;
            this.btTaoMoi.Text = "Tạo mới";
            this.btTaoMoi.UseVisualStyleBackColor = true;
            this.btTaoMoi.Visible = false;
            // 
            // btXacNhan
            // 
            this.btXacNhan.Enabled = false;
            this.btXacNhan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXacNhan.Location = new System.Drawing.Point(568, 322);
            this.btXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(152, 43);
            this.btXacNhan.TabIndex = 16;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(220, 333);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(261, 30);
            this.txtMaPhong.TabIndex = 9;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(220, 197);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(261, 30);
            this.txtCMND.TabIndex = 10;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(220, 87);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(261, 30);
            this.txtHoTen.TabIndex = 11;
            this.txtHoTen.TextChanged += new System.EventHandler(this.TxtHoTen_TextChanged);
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhong.Location = new System.Drawing.Point(89, 343);
            this.lbMaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(103, 23);
            this.lbMaPhong.TabIndex = 4;
            this.lbMaPhong.Text = "Mã phòng:";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.Location = new System.Drawing.Point(32, 207);
            this.lbCMND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(155, 23);
            this.lbCMND.TabIndex = 5;
            this.lbCMND.Text = "Chứng minh thư:";
            // 
            // lbNgayTraPhongMoi
            // 
            this.lbNgayTraPhongMoi.AutoSize = true;
            this.lbNgayTraPhongMoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTraPhongMoi.Location = new System.Drawing.Point(564, 207);
            this.lbNgayTraPhongMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayTraPhongMoi.Name = "lbNgayTraPhongMoi";
            this.lbNgayTraPhongMoi.Size = new System.Drawing.Size(189, 23);
            this.lbNgayTraPhongMoi.TabIndex = 6;
            this.lbNgayTraPhongMoi.Text = "Ngày trả phòng mới:";
            // 
            // lbNgayTraPhong
            // 
            this.lbNgayTraPhong.AutoSize = true;
            this.lbNgayTraPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTraPhong.Location = new System.Drawing.Point(607, 89);
            this.lbNgayTraPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayTraPhong.Name = "lbNgayTraPhong";
            this.lbNgayTraPhong.Size = new System.Drawing.Size(150, 23);
            this.lbNgayTraPhong.TabIndex = 7;
            this.lbNgayTraPhong.Text = "Ngày trả phòng:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(121, 89);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(73, 23);
            this.lbHoTen.TabIndex = 8;
            this.lbHoTen.Text = "Họ tên:";
            // 
            // FormGiaHanPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 550);
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
            this.IsMdiContainer = true;
            this.Name = "FormGiaHanPhong";
            this.Text = "FormGiaHanPhong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayTraPhongMoi;
        private System.Windows.Forms.DateTimePicker dtpNgayTraPhong;
        private System.Windows.Forms.Button btTroLai;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btXacThuc;
        private System.Windows.Forms.Button btTaoMoi;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbNgayTraPhongMoi;
        private System.Windows.Forms.Label lbNgayTraPhong;
        private System.Windows.Forms.Label lbHoTen;
    }
}