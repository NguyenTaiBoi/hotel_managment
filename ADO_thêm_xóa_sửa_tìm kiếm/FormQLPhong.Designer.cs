namespace GUI
{
    partial class FormQLPhong
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
            this.dgvChonPhong1 = new System.Windows.Forms.DataGridView();
            this.txtsoPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtloaiPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgiaPhong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtmoTa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.soPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonPhong1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChonPhong1
            // 
            this.dgvChonPhong1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonPhong1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soPhong,
            this.loaiPhong,
            this.giaPhong,
            this.moTa});
            this.dgvChonPhong1.Location = new System.Drawing.Point(12, 327);
            this.dgvChonPhong1.Name = "dgvChonPhong1";
            this.dgvChonPhong1.RowHeadersWidth = 51;
            this.dgvChonPhong1.RowTemplate.Height = 24;
            this.dgvChonPhong1.Size = new System.Drawing.Size(613, 172);
            this.dgvChonPhong1.TabIndex = 0;
            // 
            // txtsoPhong
            // 
            this.txtsoPhong.Location = new System.Drawing.Point(102, 33);
            this.txtsoPhong.Name = "txtsoPhong";
            this.txtsoPhong.Size = new System.Drawing.Size(250, 22);
            this.txtsoPhong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phòng";
            // 
            // txtloaiPhong
            // 
            this.txtloaiPhong.Location = new System.Drawing.Point(102, 105);
            this.txtloaiPhong.Name = "txtloaiPhong";
            this.txtloaiPhong.Size = new System.Drawing.Size(250, 22);
            this.txtloaiPhong.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá Phòng";
            // 
            // txtgiaPhong
            // 
            this.txtgiaPhong.Location = new System.Drawing.Point(102, 171);
            this.txtgiaPhong.Name = "txtgiaPhong";
            this.txtgiaPhong.Size = new System.Drawing.Size(250, 22);
            this.txtgiaPhong.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(402, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 54);
            this.button3.TabIndex = 10;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txtmoTa
            // 
            this.txtmoTa.Location = new System.Drawing.Point(102, 240);
            this.txtmoTa.Name = "txtmoTa";
            this.txtmoTa.Size = new System.Drawing.Size(250, 22);
            this.txtmoTa.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mô Tả";
            // 
            // soPhong
            // 
            this.soPhong.DataPropertyName = "soPhong";
            this.soPhong.HeaderText = "Mã Phòng";
            this.soPhong.MinimumWidth = 6;
            this.soPhong.Name = "soPhong";
            // 
            // loaiPhong
            // 
            this.loaiPhong.DataPropertyName = "loaiPhong";
            this.loaiPhong.HeaderText = "Loại Phòng";
            this.loaiPhong.MinimumWidth = 6;
            this.loaiPhong.Name = "loaiPhong";
            // 
            // giaPhong
            // 
            this.giaPhong.DataPropertyName = "giaPhong";
            this.giaPhong.HeaderText = "Giá Phòng";
            this.giaPhong.MinimumWidth = 6;
            this.giaPhong.Name = "giaPhong";
            this.giaPhong.Width = 125;
            // 
            // moTa
            // 
            this.moTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moTa.DataPropertyName = "moTa";
            this.moTa.HeaderText = "Mô Tả";
            this.moTa.MinimumWidth = 6;
            this.moTa.Name = "moTa";
            // 
            // FormQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 511);
            this.Controls.Add(this.txtmoTa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtgiaPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtloaiPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsoPhong);
            this.Controls.Add(this.dgvChonPhong1);
            this.Name = "FormQLPhong";
            this.Text = "Quản Lý Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonPhong1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.FormQLPhong_Load);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChonPhong1;
        private System.Windows.Forms.TextBox txtsoPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtloaiPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgiaPhong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtmoTa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn soPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
    }
}