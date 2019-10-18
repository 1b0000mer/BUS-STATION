namespace NHAXE_ENTITIES
{
    partial class frmLichKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichKH));
            this.btnReload = new System.Windows.Forms.Button();
            this.cbSoHieu = new System.Windows.Forms.ComboBox();
            this.cbMaCXe = new System.Windows.Forms.ComboBox();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnDatCho = new System.Windows.Forms.Button();
            this.btnXeKhach = new System.Windows.Forms.Button();
            this.btnChuyenXe = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvLichKH = new System.Windows.Forms.DataGridView();
            this.dayNDi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(22, 391);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(49, 46);
            this.btnReload.TabIndex = 9;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cbSoHieu
            // 
            this.cbSoHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbSoHieu.FormattingEnabled = true;
            this.cbSoHieu.Location = new System.Drawing.Point(102, 86);
            this.cbSoHieu.Name = "cbSoHieu";
            this.cbSoHieu.Size = new System.Drawing.Size(140, 24);
            this.cbSoHieu.TabIndex = 5;
            // 
            // cbMaCXe
            // 
            this.cbMaCXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMaCXe.FormattingEnabled = true;
            this.cbMaCXe.Location = new System.Drawing.Point(102, 51);
            this.cbMaCXe.Name = "cbMaCXe";
            this.cbMaCXe.Size = new System.Drawing.Size(140, 24);
            this.cbMaCXe.TabIndex = 3;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Image = global::NHAXE_ENTITIES.Properties.Resources.find16;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(248, 15);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(81, 59);
            this.btnNhanVien.TabIndex = 6;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanCong.Location = new System.Drawing.Point(248, 80);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(81, 36);
            this.btnPhanCong.TabIndex = 9;
            this.btnPhanCong.Text = "Phân Công";
            this.btnPhanCong.UseVisualStyleBackColor = true;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // btnDatCho
            // 
            this.btnDatCho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatCho.Location = new System.Drawing.Point(335, 80);
            this.btnDatCho.Name = "btnDatCho";
            this.btnDatCho.Size = new System.Drawing.Size(92, 36);
            this.btnDatCho.TabIndex = 10;
            this.btnDatCho.Text = "Đặt Chỗ";
            this.btnDatCho.UseVisualStyleBackColor = true;
            this.btnDatCho.Click += new System.EventHandler(this.btnDatCho_Click);
            // 
            // btnXeKhach
            // 
            this.btnXeKhach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXeKhach.Location = new System.Drawing.Point(433, 80);
            this.btnXeKhach.Name = "btnXeKhach";
            this.btnXeKhach.Size = new System.Drawing.Size(92, 36);
            this.btnXeKhach.TabIndex = 11;
            this.btnXeKhach.Text = "Xe Khách";
            this.btnXeKhach.UseVisualStyleBackColor = true;
            this.btnXeKhach.Click += new System.EventHandler(this.btnXeKhach_Click);
            // 
            // btnChuyenXe
            // 
            this.btnChuyenXe.Image = global::NHAXE_ENTITIES.Properties.Resources.find16;
            this.btnChuyenXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuyenXe.Location = new System.Drawing.Point(433, 15);
            this.btnChuyenXe.Name = "btnChuyenXe";
            this.btnChuyenXe.Size = new System.Drawing.Size(92, 59);
            this.btnChuyenXe.TabIndex = 8;
            this.btnChuyenXe.Text = "Chuyến Xe";
            this.btnChuyenXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChuyenXe.UseVisualStyleBackColor = true;
            this.btnChuyenXe.Click += new System.EventHandler(this.btnChuyenXe_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Image = global::NHAXE_ENTITIES.Properties.Resources.find16;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(335, 15);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(92, 59);
            this.btnKhachHang.TabIndex = 7;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(495, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 46);
            this.btnExit.TabIndex = 13;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(332, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 46);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(254, 391);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(49, 46);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvLichKH
            // 
            this.dgvLichKH.AllowUserToAddRows = false;
            this.dgvLichKH.AllowUserToDeleteRows = false;
            this.dgvLichKH.AllowUserToResizeColumns = false;
            this.dgvLichKH.AllowUserToResizeRows = false;
            this.dgvLichKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLichKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichKH.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLichKH.Location = new System.Drawing.Point(12, 12);
            this.dgvLichKH.Name = "dgvLichKH";
            this.dgvLichKH.Size = new System.Drawing.Size(532, 245);
            this.dgvLichKH.TabIndex = 7;
            this.dgvLichKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichKH_CellClick);
            // 
            // dayNDi
            // 
            this.dayNDi.CustomFormat = "dd/mm/yyyy";
            this.dayNDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dayNDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dayNDi.Location = new System.Drawing.Point(103, 15);
            this.dayNDi.Name = "dayNDi";
            this.dayNDi.Size = new System.Drawing.Size(139, 23);
            this.dayNDi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Hiệu Xe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Chuyến Xe:";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Location = new System.Drawing.Point(177, 391);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(49, 46);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày Đi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSoHieu);
            this.groupBox1.Controls.Add(this.cbMaCXe);
            this.groupBox1.Controls.Add(this.btnNhanVien);
            this.groupBox1.Controls.Add(this.btnPhanCong);
            this.groupBox1.Controls.Add(this.btnDatCho);
            this.groupBox1.Controls.Add(this.btnXeKhach);
            this.groupBox1.Controls.Add(this.btnChuyenXe);
            this.groupBox1.Controls.Add(this.btnKhachHang);
            this.groupBox1.Controls.Add(this.dayNDi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 122);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết";
            // 
            // frmLichKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 446);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvLichKH);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLichKH";
            this.Text = "Quản Lích Lịch Khởi Hành";
            this.Load += new System.EventHandler(this.frmLichKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox cbSoHieu;
        private System.Windows.Forms.ComboBox cbMaCXe;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Button btnDatCho;
        private System.Windows.Forms.Button btnXeKhach;
        private System.Windows.Forms.Button btnChuyenXe;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvLichKH;
        private System.Windows.Forms.DateTimePicker dayNDi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}