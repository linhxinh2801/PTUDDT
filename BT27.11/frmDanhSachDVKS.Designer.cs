namespace BT27._11
{
    partial class frmDanhSachDVKS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLoaiDV = new System.Windows.Forms.Label();
            this.lblTongDichVu = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cbbLoaiDV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvDanhSachDichVu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchByName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbLoaiDV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1029, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc và tìm kiếm";
            // 
            // lblLoaiDV
            // 
            this.lblLoaiDV.AutoSize = true;
            this.lblLoaiDV.Location = new System.Drawing.Point(376, 694);
            this.lblLoaiDV.Name = "lblLoaiDV";
            this.lblLoaiDV.Size = new System.Drawing.Size(30, 25);
            this.lblLoaiDV.TabIndex = 5;
            this.lblLoaiDV.Text = "...";
            // 
            // lblTongDichVu
            // 
            this.lblTongDichVu.AutoSize = true;
            this.lblTongDichVu.Location = new System.Drawing.Point(134, 694);
            this.lblTongDichVu.Name = "lblTongDichVu";
            this.lblTongDichVu.Size = new System.Drawing.Size(30, 25);
            this.lblTongDichVu.TabIndex = 4;
            this.lblTongDichVu.Text = "...";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(190, 694);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(180, 25);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "thuộc loại dịch vụ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(30, 694);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(98, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Có tất cả";
            // 
            // cbbLoaiDV
            // 
            this.cbbLoaiDV.FormattingEnabled = true;
            this.cbbLoaiDV.Items.AddRange(new object[] {
            "Nhà hàng",
            "Giặt ủi",
            "Spa",
            "Thuê xe"});
            this.cbbLoaiDV.Location = new System.Drawing.Point(157, 47);
            this.cbbLoaiDV.Name = "cbbLoaiDV";
            this.cbbLoaiDV.Size = new System.Drawing.Size(316, 33);
            this.cbbLoaiDV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Dịch Vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvDanhSachDichVu);
            this.groupBox2.Location = new System.Drawing.Point(23, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(978, 532);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách dịch vụ";
            // 
            // lvDanhSachDichVu
            // 
            this.lvDanhSachDichVu.CheckBoxes = true;
            this.lvDanhSachDichVu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDanhSachDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSachDichVu.GridLines = true;
            this.lvDanhSachDichVu.HideSelection = false;
            this.lvDanhSachDichVu.Location = new System.Drawing.Point(3, 27);
            this.lvDanhSachDichVu.Name = "lvDanhSachDichVu";
            this.lvDanhSachDichVu.Size = new System.Drawing.Size(972, 502);
            this.lvDanhSachDichVu.TabIndex = 0;
            this.lvDanhSachDichVu.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachDichVu.View = System.Windows.Forms.View.Details;
            this.lvDanhSachDichVu.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachDichVu_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 185;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Loại DV";
            this.columnHeader2.Width = 208;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên dịch vụ";
            this.columnHeader3.Width = 190;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 126;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ghi chú";
            this.columnHeader5.Width = 156;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm theo tên";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(710, 44);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(271, 31);
            this.txtSearchByName.TabIndex = 3;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // frmDanhSachDVKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 737);
            this.Controls.Add(this.lblLoaiDV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblTongDichVu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label);
            this.Name = "frmDanhSachDVKS";
            this.Text = "Quản lý danh sách dịch vụ";
            this.Load += new System.EventHandler(this.frmDanhSachDVKS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbLoaiDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvDanhSachDichVu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblLoaiDV;
        private System.Windows.Forms.Label lblTongDichVu;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label2;
    }
}

