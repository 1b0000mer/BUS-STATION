namespace NHAXE_ENTITIES
{
    partial class frmTuyenXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTuyenXe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDDen = new System.Windows.Forms.TextBox();
            this.txtDDi = new System.Windows.Forms.TextBox();
            this.txtMaTuyen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTuyenXe = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenXe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDDen);
            this.groupBox1.Controls.Add(this.txtDDi);
            this.groupBox1.Controls.Add(this.txtMaTuyen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết";
            // 
            // txtDDen
            // 
            this.txtDDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDDen.Location = new System.Drawing.Point(86, 74);
            this.txtDDen.Name = "txtDDen";
            this.txtDDen.Size = new System.Drawing.Size(262, 23);
            this.txtDDen.TabIndex = 5;
            // 
            // txtDDi
            // 
            this.txtDDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDDi.Location = new System.Drawing.Point(87, 45);
            this.txtDDi.Name = "txtDDi";
            this.txtDDi.Size = new System.Drawing.Size(261, 23);
            this.txtDDi.TabIndex = 3;
            // 
            // txtMaTuyen
            // 
            this.txtMaTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaTuyen.Location = new System.Drawing.Point(87, 13);
            this.txtMaTuyen.Name = "txtMaTuyen";
            this.txtMaTuyen.Size = new System.Drawing.Size(100, 23);
            this.txtMaTuyen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điểm Đến:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Điểm Đi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tuyến:";
            // 
            // dgvTuyenXe
            // 
            this.dgvTuyenXe.AllowUserToAddRows = false;
            this.dgvTuyenXe.AllowUserToDeleteRows = false;
            this.dgvTuyenXe.AllowUserToResizeColumns = false;
            this.dgvTuyenXe.AllowUserToResizeRows = false;
            this.dgvTuyenXe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTuyenXe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTuyenXe.Location = new System.Drawing.Point(12, 12);
            this.dgvTuyenXe.Name = "dgvTuyenXe";
            this.dgvTuyenXe.Size = new System.Drawing.Size(354, 150);
            this.dgvTuyenXe.TabIndex = 0;
            this.dgvTuyenXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuyenXe_CellClick);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(322, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 43);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(218, 283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 43);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(168, 283);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(44, 43);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Location = new System.Drawing.Point(118, 283);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(44, 43);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnReload
            // 
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(12, 283);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(44, 43);
            this.btnReload.TabIndex = 2;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmTuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 337);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTuyenXe);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnReload);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTuyenXe";
            this.Text = "Danh Sách Tuyến Xe";
            this.Load += new System.EventHandler(this.frmTuyenXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDDen;
        private System.Windows.Forms.TextBox txtDDi;
        private System.Windows.Forms.TextBox txtMaTuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTuyenXe;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnReload;
    }
}