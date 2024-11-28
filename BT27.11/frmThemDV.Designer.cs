namespace BT27._11
{
    partial class frmThemDV
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
            this.cbbLoaiDV = new System.Windows.Forms.ComboBox();
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblBatBuoc = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHinh
            // 
            this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHinh.Location = new System.Drawing.Point(12, 12);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(372, 433);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 0;
            this.pbHinh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã dịch vụ*";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(594, 35);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.ReadOnly = true;
            this.txtMaDV.Size = new System.Drawing.Size(288, 31);
            this.txtMaDV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên mặt hàng*";
            // 
            // cbbLoaiDV
            // 
            this.cbbLoaiDV.FormattingEnabled = true;
            this.cbbLoaiDV.Items.AddRange(new object[] {
            "Nhà hàng",
            "Giặt ủi",
            "Spa",
            "Thuê xe"});
            this.cbbLoaiDV.Location = new System.Drawing.Point(594, 156);
            this.cbbLoaiDV.Name = "cbbLoaiDV";
            this.cbbLoaiDV.Size = new System.Drawing.Size(288, 33);
            this.cbbLoaiDV.TabIndex = 5;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Location = new System.Drawing.Point(594, 94);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(288, 31);
            this.txtTenMatHang.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn giá*";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(594, 232);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(288, 31);
            this.txtDonGia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hình ảnh";
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(594, 298);
            this.txtHinh.Multiline = true;
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.ReadOnly = true;
            this.txtHinh.Size = new System.Drawing.Size(288, 44);
            this.txtHinh.TabIndex = 11;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(894, 298);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(76, 44);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(27, 499);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(797, 70);
            this.txtGhiChu.TabIndex = 14;
            // 
            // lblBatBuoc
            // 
            this.lblBatBuoc.AutoSize = true;
            this.lblBatBuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatBuoc.ForeColor = System.Drawing.Color.Red;
            this.lblBatBuoc.Location = new System.Drawing.Point(36, 583);
            this.lblBatBuoc.Name = "lblBatBuoc";
            this.lblBatBuoc.Size = new System.Drawing.Size(566, 25);
            this.lblBatBuoc.TabIndex = 15;
            this.lblBatBuoc.Text = "Mã dịch vụ, Tên mặt hàng và Đơn giá bắt buộc phải nhập.";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(706, 583);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 39);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(933, 149);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(115, 44);
            this.btnAddNew.TabIndex = 17;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // frmThemDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 688);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblBatBuoc);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtHinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenMatHang);
            this.Controls.Add(this.cbbLoaiDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHinh);
            this.Name = "frmThemDV";
            this.Text = "Thêm dịch vụ";
            this.Load += new System.EventHandler(this.frmThemDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbLoaiDV;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblBatBuoc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddNew;
    }
}