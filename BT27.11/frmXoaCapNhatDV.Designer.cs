namespace BT27._11
{
    partial class frmXoaCapNhatDV
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
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLoaiDV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblBatBuoc = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnAddNew1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHinh
            // 
            this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHinh.Location = new System.Drawing.Point(61, 32);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(372, 433);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 1;
            this.pbHinh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã dịch vụ*";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(697, 29);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.ReadOnly = true;
            this.txtMaDV.Size = new System.Drawing.Size(288, 31);
            this.txtMaDV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên mặt hàng*";
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Location = new System.Drawing.Point(697, 104);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(288, 31);
            this.txtTenMatHang.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loại dịch vụ";
            // 
            // cbbLoaiDV
            // 
            this.cbbLoaiDV.FormattingEnabled = true;
            this.cbbLoaiDV.Items.AddRange(new object[] {
            "Nhà hàng",
            "Giặt ủi",
            "Spa",
            "Thuê xe"});
            this.cbbLoaiDV.Location = new System.Drawing.Point(697, 178);
            this.cbbLoaiDV.Name = "cbbLoaiDV";
            this.cbbLoaiDV.Size = new System.Drawing.Size(288, 33);
            this.cbbLoaiDV.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đơn giá*";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(697, 263);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(288, 31);
            this.txtDonGia.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hình ảnh";
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(697, 331);
            this.txtHinh.Multiline = true;
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.ReadOnly = true;
            this.txtHinh.Size = new System.Drawing.Size(288, 44);
            this.txtHinh.TabIndex = 13;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(1029, 331);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(76, 44);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(40, 553);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(1065, 96);
            this.txtGhiChu.TabIndex = 16;
            // 
            // lblBatBuoc
            // 
            this.lblBatBuoc.AutoSize = true;
            this.lblBatBuoc.Location = new System.Drawing.Point(44, 694);
            this.lblBatBuoc.Name = "lblBatBuoc";
            this.lblBatBuoc.Size = new System.Drawing.Size(566, 25);
            this.lblBatBuoc.TabIndex = 17;
            this.lblBatBuoc.Text = "Mã dịch vụ, Tên mặt hàng và Đơn giá bắt buộc phải nhập.";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(977, 680);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 39);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(689, 680);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(136, 39);
            this.btnCapnhat.TabIndex = 20;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnAddNew1
            // 
            this.btnAddNew1.Location = new System.Drawing.Point(1007, 176);
            this.btnAddNew1.Name = "btnAddNew1";
            this.btnAddNew1.Size = new System.Drawing.Size(146, 44);
            this.btnAddNew1.TabIndex = 21;
            this.btnAddNew1.Text = "Thêm mới";
            this.btnAddNew1.UseVisualStyleBackColor = true;
            // 
            // frmXoaCapNhatDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 767);
            this.Controls.Add(this.btnAddNew1);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblBatBuoc);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtHinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbLoaiDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenMatHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHinh);
            this.Name = "frmXoaCapNhatDV";
            this.Text = "Xóa/Cập nhật dịch vụ";
            this.Load += new System.EventHandler(this.frmXoaCapNhatDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbLoaiDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblBatBuoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnAddNew1;
    }
}