namespace GUI
{
    partial class FormChonPhong
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
            this.dgvChonPhong = new System.Windows.Forms.DataGridView();
            this.btChonPhong = new System.Windows.Forms.Button();
            this.soPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChonPhong
            // 
            this.dgvChonPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soPhong,
            this.loaiPhong,
            this.giaPhong,
            this.moTa});
            this.dgvChonPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvChonPhong.Location = new System.Drawing.Point(0, 0);
            this.dgvChonPhong.Name = "dgvChonPhong";
            this.dgvChonPhong.RowTemplate.Height = 24;
            this.dgvChonPhong.Size = new System.Drawing.Size(862, 317);
            this.dgvChonPhong.TabIndex = 0;
            this.dgvChonPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChonPhong_CellContentClick);
            // 
            // btChonPhong
            // 
            this.btChonPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChonPhong.ForeColor = System.Drawing.Color.Black;
            this.btChonPhong.Location = new System.Drawing.Point(621, 343);
            this.btChonPhong.Name = "btChonPhong";
            this.btChonPhong.Size = new System.Drawing.Size(201, 57);
            this.btChonPhong.TabIndex = 1;
            this.btChonPhong.Text = "Chọn Phòng";
            this.btChonPhong.UseVisualStyleBackColor = true;
            this.btChonPhong.Click += new System.EventHandler(this.btChonPhong_Click);
            // 
            // soPhong
            // 
            this.soPhong.DataPropertyName = "soPhong";
            this.soPhong.HeaderText = "Ma Phong";
            this.soPhong.Name = "soPhong";
            // 
            // loaiPhong
            // 
            this.loaiPhong.DataPropertyName = "loaiPhong";
            this.loaiPhong.HeaderText = "Loại Phòng";
            this.loaiPhong.Name = "loaiPhong";
            // 
            // giaPhong
            // 
            this.giaPhong.DataPropertyName = "giaPhong";
            this.giaPhong.HeaderText = "Giá Phòng";
            this.giaPhong.Name = "giaPhong";
            this.giaPhong.Width = 150;
            // 
            // moTa
            // 
            this.moTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moTa.DataPropertyName = "moTa";
            this.moTa.HeaderText = "Mô tả";
            this.moTa.Name = "moTa";
            // 
            // FormChonPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 412);
            this.Controls.Add(this.btChonPhong);
            this.Controls.Add(this.dgvChonPhong);
            this.Name = "FormChonPhong";
            this.Text = "FormChonPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChonPhong;
        private System.Windows.Forms.Button btChonPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn soPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
    }
}