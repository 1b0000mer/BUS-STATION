namespace NHAXE_ENTITIES
{
    partial class frmChuyenXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenXe));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaCXe = new System.Windows.Forms.TextBox();
            this.timeGDen = new System.Windows.Forms.DateTimePicker();
            this.timeGDi = new System.Windows.Forms.DateTimePicker();
            this.cbMaTuyen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChuyenXe = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenXe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Image = global::NHAXE_ENTITIES.Properties.Resources.check;
            this.btnExit.Location = new System.Drawing.Point(262, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 43);
            this.btnExit.TabIndex = 13;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::NHAXE_ENTITIES.Properties.Resources.minus;
            this.btnDelete.Location = new System.Drawing.Point(189, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 43);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::NHAXE_ENTITIES.Properties.Resources.edit;
            this.btnUpdate.Location = new System.Drawing.Point(139, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(44, 43);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::NHAXE_ENTITIES.Properties.Resources.Add;
            this.btnInsert.Location = new System.Drawing.Point(89, 330);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(44, 43);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnReload
            // 
            this.btnReload.Image = global::NHAXE_ENTITIES.Properties.Resources.Refresh;
            this.btnReload.Location = new System.Drawing.Point(12, 330);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(44, 43);
            this.btnReload.TabIndex = 9;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaCXe);
            this.groupBox1.Controls.Add(this.timeGDen);
            this.groupBox1.Controls.Add(this.timeGDi);
            this.groupBox1.Controls.Add(this.cbMaTuyen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 147);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết";
            // 
            // txtMaCXe
            // 
            this.txtMaCXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMaCXe.Location = new System.Drawing.Point(112, 17);
            this.txtMaCXe.Name = "txtMaCXe";
            this.txtMaCXe.Size = new System.Drawing.Size(176, 22);
            this.txtMaCXe.TabIndex = 1;
            // 
            // timeGDen
            // 
            this.timeGDen.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.timeGDen.CustomFormat = "HH:mm:ss";
            this.timeGDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.timeGDen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeGDen.Location = new System.Drawing.Point(112, 112);
            this.timeGDen.Name = "timeGDen";
            this.timeGDen.ShowUpDown = true;
            this.timeGDen.Size = new System.Drawing.Size(176, 22);
            this.timeGDen.TabIndex = 7;
            // 
            // timeGDi
            // 
            this.timeGDi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.timeGDi.CustomFormat = "";
            this.timeGDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.timeGDi.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeGDi.Location = new System.Drawing.Point(113, 80);
            this.timeGDi.Name = "timeGDi";
            this.timeGDi.ShowUpDown = true;
            this.timeGDi.Size = new System.Drawing.Size(175, 22);
            this.timeGDi.TabIndex = 5;
            this.timeGDi.Value = new System.DateTime(2018, 5, 30, 11, 49, 0, 0);
            // 
            // cbMaTuyen
            // 
            this.cbMaTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbMaTuyen.FormattingEnabled = true;
            this.cbMaTuyen.Location = new System.Drawing.Point(113, 46);
            this.cbMaTuyen.Name = "cbMaTuyen";
            this.cbMaTuyen.Size = new System.Drawing.Size(175, 24);
            this.cbMaTuyen.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giờ Đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giờ Đi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Tuyến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = " Mã Chuyến Xe:";
            // 
            // dgvChuyenXe
            // 
            this.dgvChuyenXe.AllowUserToAddRows = false;
            this.dgvChuyenXe.AllowUserToDeleteRows = false;
            this.dgvChuyenXe.AllowUserToResizeColumns = false;
            this.dgvChuyenXe.AllowUserToResizeRows = false;
            this.dgvChuyenXe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChuyenXe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChuyenXe.Location = new System.Drawing.Point(12, 12);
            this.dgvChuyenXe.Name = "dgvChuyenXe";
            this.dgvChuyenXe.Size = new System.Drawing.Size(294, 150);
            this.dgvChuyenXe.TabIndex = 7;
            this.dgvChuyenXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenXe_CellClick);
            // 
            // frmChuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 380);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvChuyenXe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChuyenXe";
            this.Text = "Quản Lí Chuyến Xe";
            this.Load += new System.EventHandler(this.frmChuyenXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaCXe;
        private System.Windows.Forms.DateTimePicker timeGDen;
        private System.Windows.Forms.DateTimePicker timeGDi;
        private System.Windows.Forms.ComboBox cbMaTuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChuyenXe;
    }
}