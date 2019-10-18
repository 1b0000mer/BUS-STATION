namespace NHAXE_ENTITIES
{
    partial class frmDatCho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatCho));
            this.dgvDatCho = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXem1 = new System.Windows.Forms.Button();
            this.cbNDi = new System.Windows.Forms.ComboBox();
            this.cbMaCXe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.btnXem2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatCho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatCho
            // 
            this.dgvDatCho.AllowUserToAddRows = false;
            this.dgvDatCho.AllowUserToDeleteRows = false;
            this.dgvDatCho.AllowUserToResizeColumns = false;
            this.dgvDatCho.AllowUserToResizeRows = false;
            this.dgvDatCho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatCho.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDatCho.Location = new System.Drawing.Point(12, 12);
            this.dgvDatCho.Name = "dgvDatCho";
            this.dgvDatCho.Size = new System.Drawing.Size(568, 178);
            this.dgvDatCho.TabIndex = 6;
            this.dgvDatCho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatCho_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(331, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 46);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Location = new System.Drawing.Point(195, 313);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(82, 46);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(12, 313);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(49, 46);
            this.btnReload.TabIndex = 8;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mã Khách Hàng:";
            // 
            // btnXem1
            // 
            this.btnXem1.Image = ((System.Drawing.Image)(resources.GetObject("btnXem1.Image")));
            this.btnXem1.Location = new System.Drawing.Point(79, 48);
            this.btnXem1.Name = "btnXem1";
            this.btnXem1.Size = new System.Drawing.Size(30, 23);
            this.btnXem1.TabIndex = 14;
            this.btnXem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem1.UseVisualStyleBackColor = true;
            this.btnXem1.Click += new System.EventHandler(this.btnXem1_Click);
            // 
            // cbNDi
            // 
            this.cbNDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNDi.FormattingEnabled = true;
            this.cbNDi.Location = new System.Drawing.Point(115, 48);
            this.cbNDi.Name = "cbNDi";
            this.cbNDi.Size = new System.Drawing.Size(440, 24);
            this.cbNDi.TabIndex = 15;
            // 
            // cbMaCXe
            // 
            this.cbMaCXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMaCXe.FormattingEnabled = true;
            this.cbMaCXe.Location = new System.Drawing.Point(115, 78);
            this.cbMaCXe.Name = "cbMaCXe";
            this.cbMaCXe.Size = new System.Drawing.Size(440, 24);
            this.cbMaCXe.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã Chuyến Xe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày Đi:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(531, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 46);
            this.btnExit.TabIndex = 11;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaKH);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnXem2);
            this.groupBox1.Controls.Add(this.btnXem1);
            this.groupBox1.Controls.Add(this.cbNDi);
            this.groupBox1.Controls.Add(this.cbMaCXe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 111);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đặt Chỗ";
            // 
            // cbMaKH
            // 
            this.cbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(115, 15);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(121, 24);
            this.cbMaKH.TabIndex = 18;
            // 
            // btnXem2
            // 
            this.btnXem2.Image = ((System.Drawing.Image)(resources.GetObject("btnXem2.Image")));
            this.btnXem2.Location = new System.Drawing.Point(242, 15);
            this.btnXem2.Name = "btnXem2";
            this.btnXem2.Size = new System.Drawing.Size(30, 23);
            this.btnXem2.TabIndex = 14;
            this.btnXem2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem2.UseVisualStyleBackColor = true;
            this.btnXem2.Click += new System.EventHandler(this.btnXem2_Click);
            // 
            // frmDatCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 367);
            this.Controls.Add(this.dgvDatCho);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatCho";
            this.Text = "Đặt Chỗ";
            this.Load += new System.EventHandler(this.frmDatCho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatCho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatCho;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXem1;
        private System.Windows.Forms.ComboBox cbNDi;
        private System.Windows.Forms.ComboBox cbMaCXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.Button btnXem2;
    }
}